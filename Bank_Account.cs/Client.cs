using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
    class Client:Account
    {
        private string address;
        

        //public string Name
        //{
        //    get { return this.Name; }
        //    set { this.Name = value; }
        //}
        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }

        public Client()
        {

        }

        public Client(string name,int accountNumber,string address)
        {
            this.name = name;
            this.accountNumber = accountNumber;
            this.Address = address;
        }

        public void ClientInfo()
        {
            Console.WriteLine("Name :" + name);
            Console.WriteLine("AccountNumber :" + accountNumber);
            Console.WriteLine("address :" +  address );
        }
        
    }
}
