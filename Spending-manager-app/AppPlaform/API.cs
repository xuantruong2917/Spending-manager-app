using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Net;
using BCrypt.Net;
using Newtonsoft.Json;

namespace AppPlaform
{
    // Thông tin tài khoản các thứ
    public class Account
    {
        public string token, userName, hone, address;
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
            string info = $"{this.walletName} chuyển ${amount}";
        }

        //Tạo giao dịch cho vay
        public void CreateLoan(double amount, string debtor, string info)
        {
            Loan loan = new Loan();
            loan.walletName = this.walletName;
        }

        //Tạo giao dịch vay
        public void CreateDebt(double amount, string lender, string info)
        {
            Debt debt = new Debt();
            debt.walletName = this.walletName;
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

    public class API
    {
        public Account AccountInfo;
        public List<Wallet> wallets = new List<Wallet>();
        public List<Loan> loans = new List<Loan>();
        public List<Debt> debts = new List<Debt>();

        public void TryLogin(string hashedPassword)
        {

        }

        /// Account
        private void FetchAccountInfo()
        {

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

    public static class Platform
    {
        private static string HashPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }

        public static string MoneyFormat(double amount)
        {
            string money = amount.ToString("C", System.Globalization.CultureInfo.GetCultureInfo("vi-VN"));
            return money;
        }

        public static API Login(string password)
        {
            API api = new API();
            string hashedPassword = HashPassword(password);
            api.TryLogin(hashedPassword);
            api.GetAccountInfo();
            return api;
        }

        public static bool SignUp(string username, string password)
        {

            return true;
        }


    }
}
