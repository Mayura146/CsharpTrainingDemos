using System;

namespace Functions
{

   
    
    class Program
    {
        // call by value
        static int add(int a=50,int b=50)
        {
            int c = a + b;
            return c;
        }

        // call by Reference

            static int addition(ref int a,ref int b)
        {
            a = 2;
            b = 2;
            return a + b;
        }

       static int multiply(int a ,int b,out int c)
        {
            c = a * b;
            
        }
        static void Main(string[] args)
        {
            int z=Program.add(23, 56);
            Console.WriteLine($"Addition is {z}");
            int x = 20; y = 20;
            int result = Program.addition(ref x, ref y);
            Console.WriteLine("Reference Function call " + result);
            Program.multiply(2, 2, out int z);
            Console.WriteLine("Value is " + z);
            Console.ReadLine();
        }
    }
}

