using System;
using System.Threading.Channels;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();

            //Enter PIN
            bool pin;
            int result;
            do
            {
                Console.WriteLine("Welcome to Bank of Salina. Please enter your 4-digit PIN.");
                pin = int.TryParse(Console.ReadLine(), out result);
            } while (!pin);
            Console.WriteLine();
            Console.WriteLine("Thank you.");
            Console.WriteLine();

            //Main Menu
            bool finished = false;
            do
            {
                Console.WriteLine("Type B for Balance, D for Deposit, or W for Withdrawal.");
                var transactionType = Console.ReadLine().ToLower();
                switch (transactionType)
                {
                    case "d":
                        bool depAmount;
                        int depResult;
                        Console.WriteLine("Enter the dollar amount you wish to deposit.");
                        depAmount = int.TryParse(Console.ReadLine(), out depResult);
                        myAccount.Deposit(depResult);
                        Console.WriteLine();
                        Console.WriteLine("Would you like another transaction? (y/n)");
                        var answer = Console.ReadLine().ToLower();
                        if(answer == "n")
                        {
                            finished = true;
                        }
                        else if(answer == "y")
                        {
                            finished = false;
                        }
                        break;
                    case "b":
                        myAccount.GetBalance();
                        Console.WriteLine();
                        Console.WriteLine("Would you like another transaction? (y/n)");
                        var answer2 = Console.ReadLine().ToLower();
                        if (answer2 == "n")
                        {
                            finished = true;
                        }
                        else if (answer2 == "y")
                        {
                            finished = false;
                        }
                        break;
                    case "w":
                        bool withAmount;
                        int withResult;
                        Console.WriteLine("Enter a dollar amount you wish to withdraw.");
                        withAmount = int.TryParse(Console.ReadLine(), out withResult);
                        myAccount.Withdrawal(withResult);
                        Console.WriteLine();
                        Console.WriteLine("Would you like another transaction? (y/n)");
                        var answer3 = Console.ReadLine().ToLower();
                        if (answer3 == "n")
                        {
                            finished = true;
                        }
                        else if (answer3 == "y")
                        {
                            finished = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Entry. Please try again.");
                        Console.WriteLine();
                        break;
                }
            } while (finished == false);
            Console.WriteLine("Thank you for visiting Bank of Salina");
            Console.WriteLine("Have a good day");


            //myAccount.GetBalance();
            //myAccount.Deposit(500);
            //myAccount.Withdrawal(100);
            //myAccount.GetBalance();
        }
    }
}
