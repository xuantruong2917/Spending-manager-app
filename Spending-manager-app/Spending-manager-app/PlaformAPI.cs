using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Net;
using System.Text.Json;
using System.Security.Cryptography;
using RestSharp;
using Newtonsoft.Json;

namespace Spending_manager_app
{

    public class Response
    {
        public string Content;
        public HttpStatusCode StatusCode;
    }

    public class Account
    {
        public string username, fullname, phone, address;
        public long createdOn;
        public void ChangePassword(string newPassword)
        {
            string hashedPassword = AppPlatform.HashPassword(newPassword);
            var result = AppPlatform.API.POSTData("editaccount", new { password = hashedPassword });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
        }
        public void ChangeInfo(string new_fullname, string new_phone, string new_address)
        {
            var result = AppPlatform.API.POSTData("editaccount", new { fullname = new_fullname, phone = new_phone, address = new_address });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");

            Account account = AppPlatform.API.GetAccountInfo();
            this.fullname = account.fullname;
            this.phone = account.phone;
            this.address = account.address;
        }
    }

    // Thông tin ví và các hàm canh thiệp ví;
    public class Wallet
    {
        public string id;
        public string walletName, type;
        public double balance;
        public long createdOn;

        public void ChangeInfo(string new_walletName, string new_type)
        {
            var result = AppPlatform.API.POSTData("wallet/edit", new { walletId = this.id, walletName = new_walletName, type = new_type });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }

        // Thu
        public void Deposit(double amount, string info, DateTime? createdOn = null)
        {
            if (!createdOn.HasValue)
                createdOn = DateTime.Now;

            var result = AppPlatform.API.POSTData("wallet/deposit", new { walletId = this.id, amount = amount, info = info, createdOn = createdOn });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }

        // Chi
        public void Withdraw(double amount, string info, DateTime? createdOn = null)
        {
            if (!createdOn.HasValue)
                createdOn = DateTime.Now;
            var result = AppPlatform.API.POSTData("wallet/withdraw", new { walletId = this.id, amount = amount, info = info, createdOn = createdOn });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }

        public void Transfer(double amount, Wallet walletRecive, DateTime? createdOn = null)
        {
            if (!createdOn.HasValue)
                createdOn = DateTime.Now;
            string info = $"Giao dịch chuyển {AppPlatform.MoneyFormat(amount)} từ Ví {this.walletName} sang Ví {walletRecive.walletName}";
            this.Withdraw(amount, info, createdOn);
            walletRecive.Deposit(amount, info, createdOn);
            this.Load();
            walletRecive.Load();
        }

        //Tạo giao dịch cho vay
        public void CreateLoan(double amount, string debtor, string info, DateTime? createdOn = null)
        {
            if (!createdOn.HasValue)
                createdOn = DateTime.Now;
            var result = AppPlatform.API.POSTData("wallet/createloan", new { walletId = this.id, amount = amount, debtor = debtor, info = info, createdOn = createdOn });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }

        //Tạo giao dịch vay
        public void CreateDebt(double amount, string lender, string info, DateTime? createdOn = null)
        {
            if (!createdOn.HasValue)
                createdOn = DateTime.Now;
            var result = AppPlatform.API.POSTData("wallet/createdebt", new { walletId = this.id, amount = amount, lender = lender, info = info, createdOn = createdOn });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }

        public List<Loan> GetLoans()
        {
            var response = AppPlatform.API.POSTData("wallet/loans", new {walletId = this.id });
            return AppPlatform.JSONParse<List<Loan>>(response.Content);
        }


        public List<Debt> GetDebts()
        {
            var response = AppPlatform.API.POSTData("wallet/debts", new {walletId = this.id });
            return AppPlatform.JSONParse<List<Debt>>(response.Content);
        }


        //Thu Nợ
        public void PayLoan(Loan loan, DateTime? paymentedOn = null)
        {
            if (loan.isPaymented)
            {
                MessageBox.Show("Khoảng cho vay này đang ở trạng thái ĐÃ THU", "Thông báo");
                return;
            }

            if (!paymentedOn.HasValue)
                paymentedOn = DateTime.Now;

            var result = AppPlatform.API.POSTData("wallet/payloan", new { walletId = this.id, loanId = loan.id, paymentedOn = paymentedOn });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }
        // Trả Nợ
        public void PayDebt(Debt debt, DateTime? paymentedOn = null)
        {
            if (debt.isPaymented)
            {
                MessageBox.Show("Khoảng vay này đang ở trạng thái ĐÃ TRẢ", "Thông báo");
                return;
            } 

            if (!paymentedOn.HasValue)
                paymentedOn = DateTime.Now;

            var result = AppPlatform.API.POSTData("wallet/paydebt", new { walletId = this.id, debtId = debt.id, paymentedOn = paymentedOn });
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
            this.Load();
        }

        public List<Transaction> GetTransactions()
        {
            var response = AppPlatform.API.POSTData("wallet/transactions", new { walletId = this.id });
            return AppPlatform.JSONParse<List<Transaction>>(response.Content);
        }

        public void Load()
        {
            var response = AppPlatform.API.POSTData("wallet/load", new { walletId = this.id });
            Wallet wallet = AppPlatform.JSONParse<Wallet>(response.Content);
            this.walletName = wallet.walletName;
            this.type = wallet.type;
            this.balance = wallet.balance;
        }
    }

    // Thông tin giao dịch
    public class Transaction
    {
        public string id;
        public string walletName;
        public double amount;
        public string info;
        public long createdOn;
    }

    // Thông tin Cho Vay
    public class Loan
    {
        public string id;
        public string walletName, debtor, info;
        public double amount;
        public long createdOn, paymentedOn;
        public bool isPaymented = false;

    }

    // Thông tin Vay
    public class Debt
    {
        public string id;
        public string walletName, lender, info;
        public double amount;
        public long createdOn, paymentedOn;
        public bool isPaymented = false;
    }

    public class AppAPI
    {
        //public string url = "http://localhost:5000";
        public string url =  "https://spendingmanager.up.railway.app/";
        public string token = "";
        public bool isLogin = false;
        public bool firstLogin = true;



        public Response POSTData(string path, object body)
        {   

            if (!this.isLogin)
            {
                if (!this.firstLogin)
                    MessageBox.Show("Vui lòng đăng nhập trước khi sử dụng tính năng", "Thông Báo");
                else
                    this.firstLogin = false;


                for (var i = 0; i < Application.OpenForms.Count; i++)
                {
                    var form = Application.OpenForms[i];
                    form.Hide();
                }

                Frm_Login loginForm = new Frm_Login();
                loginForm.ShowDialog();



                if (loginForm.close)
                {
                    if (MessageBox.Show("Bạn có chắc là muốn thoát chương trình không?", "Thông báo",MessageBoxButtons.YesNo) == DialogResult.Yes)
                        Environment.Exit(0);
                    
                }
                for (var i = 0; i < Application.OpenForms.Count; i++)
                {
                    var form = Application.OpenForms[i];
                    form.Show();
                    form.Focus();
                    form.BringToFront();
                }
            }

            return PostRequest(path, body);
        }

        public Response PostRequest(string path, object body)
        {
            try
            {
                var client = new RestClient(this.url);
                var request = new RestRequest(path, Method.POST);
                request.AddHeader("token-user", this.token);
                request.AddJsonBody(body);

                var response = client.Execute(request);
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    dynamic res = AppPlatform.JSONParse<object>(response.Content);
                    MessageBox.Show($"Lỗi xác thực: {res.error}", "Có lỗi xảy ra", MessageBoxButtons.OK);
                    this.token = "";
                    this.isLogin = false;
                    return POSTData(path, body);
                }
                else if(response.StatusCode != HttpStatusCode.OK)
                {
                    dynamic res = AppPlatform.JSONParse<object>(response.Content);
                    MessageBox.Show($"Lỗi : {res.error}", "Có lỗi xảy ra", MessageBoxButtons.OK);
                    var tryAgain = PostRequest(path, body);
                    return tryAgain;
                }
                
                return new Response
                {
                    Content = response.Content,
                    StatusCode = response.StatusCode
                };
            }
            catch (Exception ex)    
            {
                MessageBox.Show($"Lỗi HTTP POST: {ex.ToString()}", "Có lỗi xảy ra", MessageBoxButtons.OK);
                var tryAgain = PostRequest(path, body);
                return tryAgain;
            }
        }
        



        public bool Login(string user, string password)
        {
            string hashedPassword = AppPlatform.HashPassword(password);
            var res = PostRequest("login", new { username = user, password = hashedPassword });
            
            dynamic data = AppPlatform.JSONParse<object>(res.Content);
            this.token = data.token.ToString();
            this.isLogin = (this.token != "");

            return this.isLogin;
        }

        public string SignUp(string username, string password, string fullname, string phone, string address)
        {
            string hashedPassword = AppPlatform.HashPassword(password);
            var res = PostRequest("signup", new  {
                username = username, 
                password = hashedPassword,
                fullname = fullname,
                phone = phone,  
                address = address
            });
            dynamic data = AppPlatform.JSONParse<object>(res.Content);

            return data.message;
        }

        public Account GetAccountInfo()
        {
            var response = POSTData("account", new { });
            return AppPlatform.JSONParse<Account>(response.Content); 
        }


        public List<Wallet> GetWallets()
        {
            var response = POSTData("wallets", new { });
            return AppPlatform.JSONParse<List<Wallet>>(response.Content);
        }

        public void CreateWallet(string walletName, string type)
        {
            var result = POSTData("createwallet", new { walletName = walletName, type = type});
            dynamic response = AppPlatform.JSONParse<Object>(result.Content);
            MessageBox.Show(response.message.ToString(), "Thông Báo");
        }
    }

    public static class AppPlatform
    {
        public static AppAPI API = new AppAPI();
        public static string HashPassword(string password)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(password);
            using (var hash = SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }

        public static string MoneyFormat(double amount)
        {
            string money = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            return money;
        }

        public static T JSONParse<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static string JSONStringify(Object value)
        {
            return JsonConvert.SerializeObject(value);
        }


    }

}
