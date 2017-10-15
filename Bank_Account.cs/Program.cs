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
            
            int exit = 0;

            do
                
            {
                Console.WriteLine("Welcome to Golden's Bank");
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("Please select which number for the transaction\n you wish to make!! ");
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine(" 1.View Client Information ");
                Console.WriteLine("2.View Account Balance ");
                Console.WriteLine("3.Deposit Funds ");
                Console.WriteLine("4.Withdraw Funds ");
                Console.WriteLine("5.Exit ");

               

                Client client = new Client("Joderrick Golden ", 06231022);
                Checking checkings = new Checking();
                Savings savings = new Savings();




                int clientChoice = int.Parse(Console.ReadLine());


                switch (clientChoice)
                {
                    case 1:
                        client.ClientInfo();
                        break;

                    case 2:
                        Console.WriteLine("Please select wich balance you would like to view");
                        Console.WriteLine();

                        Console.WriteLine("select (A): checking \n select (B) ; Savings");
                        Console.WriteLine();

                        char accountType = char.Parse(Console.ReadLine().ToUpper());

                        switch (accountType)
                        {
                            case 'A':
                                Console.WriteLine("Checkings Blance : $"+checkings.Balance);
                                break;

                            case 'B':
                                Console.WriteLine("Savings Balance = $"+ savings.Balance);
                                break;


                            default:
                                break;
                        }

                        break;



                    case 3:


                        Console.WriteLine("Depoist in wich account");
                        Console.WriteLine();

                        Console.WriteLine("select (A): checking \n\n select (B) ; Savings");
                        accountType = char.Parse(Console.ReadLine().ToUpper());
                        Console.WriteLine();




                        switch (accountType)
                        {
                            case 'A':
                                Console.WriteLine("Checkings Balance: $" + checkings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("How much would you like to deposit");
                                double depoist = double.Parse(Console.ReadLine());
                                Console.WriteLine();

                                checkings.Deposit(depoist);
                                Console.WriteLine("Checkings Balance: $" + checkings.Balance);


                                break;

                            case 'B':
                                Console.WriteLine("Savings Balance : $"+ savings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("How much would you like to deposit");
                                depoist = double.Parse(Console.ReadLine());
                                Console.WriteLine();

                                savings.Deposit(depoist);
                                Console.WriteLine("Savings Balance : $" + savings.Balance);

                                break;


                            default:
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("which account would you like to withdraw from");
                        Console.WriteLine("select (A): checking \n\n select (B) ; Savings");

                        accountType = char.Parse(Console.ReadLine().ToUpper());

                        switch (accountType)
                        {
                            case 'A':
                                Console.WriteLine("Checkins Balance = $"+ checkings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("How much would you like to Withdraw");
                                double withDraw = double.Parse(Console.ReadLine());
                                Console.WriteLine();

                                checkings.WithDraw(withDraw);
                                Console.WriteLine("Your Checkings Balance is now = $"+ checkings.Balance);
                                break;

                            case 'B':
                                Console.WriteLine("Savins Blance = $"+savings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("How much would you like to Withdraw");
                                withDraw = double.Parse(Console.ReadLine());
                                Console.WriteLine();


                                savings.WithDraw(withDraw);
                                Console.WriteLine("Your Savings blance = $"+ savings.Balance);
                                break;

                            default:
                                break;


                        }

                        break;

                    case 5:

                        Console.WriteLine("are you sure you would like to Quit");
                        Console.WriteLine("If NO please press (0)");
                        Console.WriteLine("if yes press any other number");
                        int confirm = int.Parse(Console.ReadLine());

                        


                    
                        


                        exit = confirm;

                        
                        break;
                            default:
                        break;
                        

                }





                } while (exit == 0) ;



            


        }  
     
        
    }
}
