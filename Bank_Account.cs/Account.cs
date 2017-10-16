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
        protected double savingsAccount;//fields
        protected double withDraw;
        protected double deposit;
        protected double checkingAccount;
        protected string accountType;
        protected double amountOfMoney;// this will take users input 
          


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
            balance = amountOfMoney + balance;//created this method so that all accounts could use method
            return balance;
        }

        public virtual double WithDraw(double amountOfMoney)
        {
            balance = balance - amountOfMoney;
            return balance;
        }


        public abstract void View(); //this method is abstract so I can view balance's in each account.

     





    }
}
