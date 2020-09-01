using System;
using static System.Console;
namespace StaticConstructore
{
    class Program
    {
        static Program()
        {
            WriteLine("Static Constructor invoked!!");
        }

        Program()
        {
            WriteLine("Non static Constructor");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Program p1 = new Program();
            Console.WriteLine("Hello World!");
            ReadLine();
        }
    }
}
