using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
    class Account
    {
        protected string name;
        public int accountNumber;
        private double balance;
        private double checkingAccount;
        private double savingsAccount;
        private double withDraw;
        private double deposit;
          


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public int AccountNumber
        {
            get { return this.accountNumber;}
            set { this.accountNumber = value; }
        }


        public double CheckingAccount
        {
            get { return this.checkingAccount; }
        }
        





    }
}
