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
                Console.WriteLine("\t\t\tWelcome to Golden's Bank");
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("\t\t select the number for the transaction\n\t\t you wish to make!! ");
                Console.WriteLine();
                Console.WriteLine();


                Console.WriteLine("\t1.View Client Information ");
                Console.WriteLine("\t2.View Account Balance ");
                Console.WriteLine("\t3.Deposit Funds ");
                Console.WriteLine("\t4.Withdraw Funds ");
                Console.WriteLine("\t5.Exit ");

               

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
                        Console.WriteLine("\t\tPlease select wich balance you would like to view");
                        Console.WriteLine();

                        Console.WriteLine("\t\tselect (A): checking \n \t\tselect (B) : Savings");
                        Console.WriteLine();

                        char accountType = char.Parse(Console.ReadLine().ToUpper());

                        switch (accountType)
                        {
                            case 'A':
                                Console.WriteLine("\t\tCheckings Blance : $"+checkings.Balance);
                                break;

                            case 'B':
                                Console.WriteLine("\t\tSavings Balance = $"+ savings.Balance);
                                break;


                            default:
                                break;
                        }

                        break;



                    case 3:


                        Console.WriteLine("\t\tDepoist in wich account");
                        Console.WriteLine();

                        Console.WriteLine("\t\tselect (A): checking \n\t\tselect (B) : Savings");
                        accountType = char.Parse(Console.ReadLine().ToUpper());
                        Console.WriteLine();




                        switch (accountType)
                        {
                            case 'A':
                                Console.WriteLine("\t\tCheckings Balance: $" + checkings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("\t\tHow much would you like to deposit");
                                double depoist = double.Parse(Console.ReadLine());
                                Console.WriteLine();

                                checkings.Deposit(depoist);
                                Console.WriteLine("\t\tCheckings Balance: $" + checkings.Balance);


                                break;

                            case 'B':
                                Console.WriteLine("\t\tSavings Balance : $"+ savings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("\t\tHow much would you like to deposit");
                                depoist = double.Parse(Console.ReadLine());
                                Console.WriteLine();

                                savings.Deposit(depoist);
                                Console.WriteLine("\t\tSavings Balance : $" + savings.Balance);

                                break;


                            default:
                                break;
                        }
                        break;

                    case 4:
                        Console.WriteLine("\t\twhich account would you like to withdraw from");
                        Console.WriteLine("\t\tselect (A): checking \n\n\t\t select (B) : Savings");

                        accountType = char.Parse(Console.ReadLine().ToUpper());

                        switch (accountType)
                        {
                            case 'A':
                                Console.WriteLine("\t\tCheckins Balance = $"+ checkings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("\t\tHow much would you like to Withdraw");
                                double withDraw = double.Parse(Console.ReadLine());
                                Console.WriteLine();

                                checkings.WithDraw(withDraw);
                                Console.WriteLine("\t\tYour Checkings Balance is now = $"+ checkings.Balance);
                                break;

                            case 'B':
                                Console.WriteLine("\t\tSavins Blance = $"+savings.Balance);
                                Console.WriteLine();

                                Console.WriteLine("\t\tHow much would you like to Withdraw");
                                withDraw = double.Parse(Console.ReadLine());
                                Console.WriteLine();


                                savings.WithDraw(withDraw);
                                Console.WriteLine("\t\tYour Savings blance = $"+ savings.Balance);
                                Console.WriteLine();
                                break;

                            default:
                                break;


                        }

                        break;

                    case 5:

                        Console.WriteLine("\t\tAre you sure you would like to Quit");
                        Console.WriteLine();

                        Console.WriteLine("\t\tIf NO please press (0)");
                        Console.WriteLine();

                        Console.WriteLine("\t\tIf yes press any other number");
                        int confirm = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        


                    
                        


                        exit = confirm;

                        
                        break;
                            default:
                        break;
                        

                }





                } while (exit == 0) ;



            


        }  
     
        
    }
}
