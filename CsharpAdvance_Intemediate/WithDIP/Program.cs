using System;

namespace WithDIP
{
    class Program
    {
        static void Main(string[] args)
        {
          Reminder e = new Reminder();
           // e.Start();
            Calendar c = new Calendar(e);
            c.Start();
            Console.ReadLine();
        }
    }
}
