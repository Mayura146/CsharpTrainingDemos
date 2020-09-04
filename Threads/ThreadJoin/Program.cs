using System;
using System.Threading;
namespace ThreadJoin
{
    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1 => thread started!!" +Thread.CurrentThread.Name);
       // Thread.Sleep(20000);
            Console.WriteLine("Method 1 => Thread Ended " + Thread.CurrentThread.Name);

        }

        public static void Method2()
        {
            Console.WriteLine("Method 2 => thread started!!" + Thread.CurrentThread.Name);
           Thread.Sleep(20000);
            Console.WriteLine("Method 2 => Thread Ended " + Thread.CurrentThread.Name);

        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 => thread started!!" + Thread.CurrentThread.Name);
            //Thread.Sleep(20000);
            Console.WriteLine("Method 3 => Thread Ended " + Thread.CurrentThread.Name);

        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Method1);
            Thread t2 = new Thread(Method2);
            Thread t3 = new Thread(Method3);
                t1.Name = "thread 1";
            t2.Name = "thread 2";
            t3.Name = "thread3";
            t2.Start();
           // t2.Join();
            t1.Start();
            
           
          
            t3.Start();


            Console.ReadLine();
        }
    }
}
