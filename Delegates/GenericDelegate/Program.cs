using System;

namespace GenericDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, float, double, double> func =
                new Func<int, float, double, double>(Demo.AddNumber);
            double result = func(1, 34.3f, 78.89);
            Console.WriteLine($"Addition is {result}");
            
            Action<int, float, double> action = 
                new Action<int, float, double>(Demo.AddNumber1);
            action(1, 34.3f, 56.78);

            Predicate<string> predicate = new Predicate<string>(Demo.CheckString);
            bool status = predicate("Mayura");
            Console.WriteLine(status);

            Func<int, float, double> add = (a, b) => a + b;
            Console.WriteLine($"Addition is {add(1, 2)}");
            Predicate<string> predicate1 = (name) => name.Length > 5;
            Console.WriteLine($"Length of String is {predicate1("Mayura")}");
            Console.ReadLine();
        }
    }
}
