using System;

namespace CsharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Bank b = new Bank();
            Console.WriteLine("Welocme to Bank Management System");
            while(true)
            {
                Console.WriteLine("How we can help you");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Show Account Information");
                Console.WriteLine("3. Deposit Amount");
                Console.WriteLine("4. WithDraw Amount");
                Console.WriteLine("5. Clear Screen");
                input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.WriteLine("Enter Account Type");
                        b.CreateAccount();
                        break;

                    case "2":
                        Console.WriteLine("Enter Account Id");
                        b.ShowAccountDetails();
                        break;

                    case "3":
                        //Console.WriteLine("Enter Account ID");
                        b.deposit();
                        break;
                    case "4":
                        Console.Clear();
                        break;
                    default:
                        break;
                }
                Console.ReadLine();
            }
            
            
        }
    }
}
