using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account.cs
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client("Joe", 234445, "1022 hospital ave");

            client.ClientInfo();
       

        }
    }
}
