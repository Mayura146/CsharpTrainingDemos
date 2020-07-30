using System;
using static System.Console;

namespace SwitchCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a, b;
            string operation;
            float result;
            ConsoleKeyInfo status;
            while(true)
            {
                WriteLine("Enter value for a");
                a = Int32.Parse(ReadLine());
                WriteLine("Enter value for b");
                b = Int32.Parse(ReadLine());
                WriteLine("Please specify the operation to be performed!!");
                operation = ReadLine();
                switch(operation)
                {
                    case "+":
                        result = a + b;
                        break;
                    case "-":
                        result = a - b;
                        break;
                    case "/":
                        result = a / b;
                        break;
                    case "*":
                        result = a * b;
                        break;
                    default:
                        result = 0;
                        break;
                }
                WriteLine($"Result is {result}");
                WriteLine("Do you want to break (Y/y");
                status = ReadKey();
                if(status.Key==ConsoleKey.Y)
                {
                    break;
                }
                Clear();

            }
            ReadLine();
        }
    }
}
