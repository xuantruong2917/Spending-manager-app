using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Windows.Forms;
using System.Net;
using System.Text.Json;
using BCrypt.Net;
using RestSharp;
using Newtonsoft.Json;

namespace Spending_manager_app
{
    public class Account
    {
        public string token, user, name, phone, address;
        public void ChangePassword(string newPassword)
        {
            string hashedPassword = AppPlatform.HashPassword(newPassword);


        }
    }

    // Thông tin ví và các hàm canh thiệp ví;
    public class Wallet
    {
        private string id;
        public string walletName, type;
        public double balance;
        public DateTime createdOn;

        // Thu
        public void Deposit(double amount, string info)
        {
            Transaction trans = new Transaction();
            trans.walletName = this.walletName;
            trans.amount = amount; // Thu => Dương
            trans.info = info;



        }

        // Chi
        public void Withdraw(double amount, string info)
        {
            Transaction trans = new Transaction();
            trans.walletName = this.walletName;
            trans.amount = -amount; // Chi => Âm
            trans.info = info;


        }

        public void Transfer(double amount, Wallet walletRecive)
        {
            string info = $"Giao dịch chuyển {AppPlatform.MoneyFormat(amount)} từ {this.walletName} sang {walletRecive.walletName}";
            this.Withdraw(amount, info);
            walletRecive.Deposit(amount, info);
        }

        //Tạo giao dịch cho vay
        public void CreateLoan(double amount, string debtor, string info)
        {
            Loan loan = new Loan();
            loan.walletName = this.walletName;
            loan.amount = amount;
            loan.debtor = debtor;
            loan.info = info;



        }

        //Tạo giao dịch vay
        public void CreateDebt(double amount, string lender, string info)
        {
            Debt debt = new Debt();
            debt.walletName = this.walletName;
            debt.amount = amount;
            debt.lender = lender;
            debt.info = info;



        }


    }

    // Thông tin giao dịch
    public class Transaction
    {
        private string id;
        public string walletName;
        public double amount;
        public string info;
    }

    // Thông tin Cho Vay
    public class Loan
    {
        private string id;
        public string walletName, debtor, info;
        public double amount;
        public DateTime createdOn, paymentedOn;
        public bool isPaymented = false;
    }

    // Thông tin Vay
    public class Debt
    {
        private string id;
        public string walletName, lender, info;
        public double amount;
        public DateTime createdOn, paymentedOn;
        public bool isPaymented = false;
    }

    public class AppAPI
    {
        private string url = "";
        public Account AccountInfo;
        public List<Wallet> wallets = new List<Wallet>();
        public List<Loan> loans = new List<Loan>();
        public List<Debt> debts = new List<Debt>();
        public bool isLogin = false;


        /*
            var task = Task.Run<Account>(async () => await POSTData<Account>(new RestRequest()));
            task.Wait();
            Account account = task.Result;
         */
        public async Task<T> POSTData<T>(string path, RestRequest request) where T : new()
        {
            try
            {
                var client = new RestClient(url + path + "?token=" + this.AccountInfo.token);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                T respones = await client.PostAsync<T>(request);
                return respones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi HTTP POST: {ex.ToString()}", "Có lỗi xảy ra", MessageBoxButtons.OK);
                T respones = await POSTData<T>(path, request);
                return respones;
            }
        }

        public async Task<List<T>> POSTDataList<T>(string path, RestRequest request) where T : new()
        {
            try
            {
                var client = new RestClient(url + path + "?token=" + this.AccountInfo.token);
                request.AddHeader("Content-Type", "application/json");
                request.AddHeader("Accept", "application/json");
                T respones = await client.PostAsync<T>(request);
                return respones;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi HTTP POST: {ex.ToString()}", "Có lỗi xảy ra", MessageBoxButtons.OK);
                List<T> respones = await POSTDataList<T>(path, request);
                return respones;
            }
        }
            

        public void TryLogin(string hashedPassword)
        {

            this.isLogin = true;
        }

        /// Account
        private void FetchAccountInfo()
        {
            var task = Task.Run<Account>(async() => await POSTData<Account>("accountinfo", new RestRequest()));
            task.Wait();
            this.AccountInfo = task.Result;
        }

        public Account GetAccountInfo()
        {
            FetchAccountInfo();
            return this.AccountInfo;
        }
        /// 


        /// Wallets
        private void FetchWallets()
        {
            var task = Task.Run<Wallet[]>(async () => await POSTData<Wallet[]>("wallets", new RestRequest()));
            task.Wait();
            Wallet[] wallets = task.Result;
            this.wallets.Clear();
            foreach (Wallet wallet in wallets)
                    this.wallets.Add(wallet);
        }

        public List<Wallet> GetWallets()
        {
            FetchWallets();
            return this.wallets;
        }
        /// 


        /// Loan
        private void FetchLoans()
        {

        }

        public List<Loan> GetLoans()
        {
            FetchLoans();
            return this.loans;
        }
        /// 


        /// Debt
        private void FetchDebts()
        {

        }

        public List<Debt> GetDebts()
        {
            FetchDebts();
            return this.debts;
        }
    }

    public static class AppPlatform
    {
        public static AppAPI API = new AppAPI();
        public static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static string MoneyFormat(double amount)
        {
            string money = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            return money;
        }

        public static void Login(string password)
        {
            string hashedPassword = HashPassword(password);
            API.TryLogin(hashedPassword);
            API.GetAccountInfo();
        }

        public static void SignUp(string username, string password)
        {

        }


    }

}
