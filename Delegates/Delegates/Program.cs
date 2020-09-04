using System;
using static Delegates.DelegateDemo;

namespace Delegates
{
    public class DelegateDemo
    {
        public delegate void TestDelegate();
        public delegate void Demodelegate(int a);
        // Out Parameter Delegate
        public delegate void OutParameterDelegate(out int x);
        public  void Function1()
        {
            Console.WriteLine("Function1 executed!!");
        }

        public void Function2()
        {
            Console.WriteLine("Function2 executed");
        }
        public void Function3()
        {
            Console.WriteLine("Function3 executed");
        }
        public void Function4(int a)
        {
            Console.WriteLine("Value of a is " + a);
        }
        public void Function5(int x)
        {
            Console.WriteLine("Value of x is " + x);
        }
        public static void OutParameterMethod(out int num)
        {
            num = 2;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            DelegateDemo del = new DelegateDemo();
            DelegateDemo.TestDelegate td = 
                new DelegateDemo.TestDelegate(del.Function1);
            td();
            td += del.Function2;
            td();
            td += del.Function3;
            td();
            td -= del.Function2;
            Console.WriteLine("After removing the reference");
            td();
            DelegateDemo.Demodelegate dm = new DelegateDemo.Demodelegate(del.Function4);
            dm += del.Function5;
            dm(34);
            Console.WriteLine("Delegate with out Parameter");
            OutParameterDelegate out1 = new OutParameterDelegate(OutParameterMethod);
            int value = 1;
            out1(out value);
            Console.WriteLine("Value is " + value);
            Console.ReadLine();
        }
    }
}
