using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
     abstract class Account
    {
        protected string name;
        protected int accountNumber;
        protected double balance;
        protected double savingsAccount;
        protected double withDraw;
        protected double deposit;        protected double checkingAccount;

        protected string accountType;
        protected double amountOfMoney;
          


        public string Name
        {
            get { return this.name; }
            
        }

        public double Balance
        {
            get { return this.balance; }
            
        }

        public int AccountNumber
        {
            get { return this.accountNumber;}
            
        }



    public double AmmountOfMoney
        {
            get { return this.amountOfMoney; }
        }

        public virtual double Deposit(double amountOfMoney)
        {
            balance = amountOfMoney + balance;
            return balance;
        }

        public virtual double WithDraw(double amountOfMoney)
        {
            balance = balance - amountOfMoney;
            return balance;
        }
        public abstract void View();

        public  void Quit(int number)
        {
            System.Environment.Exit(5);
        }





    }
}
