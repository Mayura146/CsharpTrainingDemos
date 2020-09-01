using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    class TestExtension
    {
       
        public static void Main()
        {
            Program p = new Program();
            TestExtension t = new TestExtension();
            TestExtension t1 = new TestExtension();
            p.Test1();
            p.Test2(4);
            int i = 6;
            int result = i.Factorial();
            Console.WriteLine($"Factorial of a number is {result}");
            Console.ReadLine();
           
        }
    }
}
