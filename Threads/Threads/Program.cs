using System;
using System.Threading;
namespace Threads
{
    class Program
    {
        public void ThreadMethod1()
        {
            
            Console.WriteLine("ThreadMethod 1" +Thread.CurrentThread.Name);
        }
        public void add ()
        {
            Thread.Sleep(20000);
            Console.WriteLine("Hello" +Thread.CurrentThread.Name);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            
            Thread t1 = new Thread(p.ThreadMethod1);
            t1.Name = "T1";
            Thread t2 = new Thread(p.add);
            t2.Name = "T2";
            t1.Start();
            t2.Start();
            Console.WriteLine("Enter the main thread" + Thread.CurrentThread.Name);
            Console.WriteLine("Exiting the main thread");
            Console.ReadLine();

            
            
        }
    }
}
