using System;


namespace Delegates
{
    public class DelegateDemo
    {
        public delegate void TestDelegate();
        public delegate void Demodelegate(int a);
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
            
            Console.ReadLine();
        }
    }
}
