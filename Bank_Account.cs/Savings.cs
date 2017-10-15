using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
    class Savings : Account
    {
        private double minAmount;

        public double MinAnount
        {

            get { return this.minAmount; }
        }

        public Savings()
        {
            this.minAmount = 50.00;
            this.balance = 400.00;
        }
        public Savings(int accountNumber, double amountOfMONEY)
        {
            this.accountNumber = accountNumber;
            this.deposit = amountOfMoney;

        }

        public override double WithDraw(double amountOfMoney)
        {

            while (balance - amountOfMoney > minAmount)
            {
                double subtract = balance -= amountOfMoney;
                return balance;

            }

            Console.WriteLine("Your account can not fall below Min Balance!!");
            return balance;
        }


        public override void View()
        {
            Console.WriteLine(balance);
        }


    

    }         
}
