using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
    class Client:Account
    {
        private string accountType;


        public string Name
        {
            get { return this.Name; }
            
        }
        public int AccountNumber
        {
            
           get { return this.accountNumber; }
        }

        public string AccountType
        {
            get { return this.accountType; }
        }

        public Client()
        {

        }

        public Client(string name,int accountNumber)
        {
            this.name = name;
            this.accountNumber =accountNumber;
            this.accountType = accountType;
        }

        public void ClientInfo() // this method is to keep track of client information.
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("AccountNumber :" + accountNumber);
            Console.WriteLine();
        }

        public override void View()
        {
            
        }


    }
}
