using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
    class Checking:Account
    {
        private double checkingsAccountBalance;





        public double  CheckingAccountBalance
        {
            get { return this.checkingsAccountBalance; }
            
        }


        public Checking()
        {
            this.balance = 2500.00;
        }

        public Checking(int accountNumber,string name)
        {
            this.accountNumber = accountNumber;
            this.name = name;


          
            this.accountType="Checkings";
        }


        public  double ViewCheckings()
        {
            return balance;
        }


        public override double WithDraw(double amountOfMoney)
        {
           double subtract = balance -= amountOfMoney;
            return balance;
            
            
        }

        public override void View()
        {
            Console.WriteLine(balance + name + accountNumber+ accountType);
        }







    }


}
