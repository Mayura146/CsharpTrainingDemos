using System;
using System.Threading.Tasks;

namespace Async_Await
{
    class Program
    {
       public async static Task<string> SendMessage()
        {
            await Task.Delay(10000);
            return "Welcome to Async Await Training!!";
        }

        public async static Task RecieveMessage()
        {
            Console.WriteLine("Async Receive Message Started!!!");

            // call Async method

            Task<string> sendMessage = SendMessage();
            Console.WriteLine("Async Method Executing");
            Console.WriteLine("Current Time" + DateTime.Now);
            Console.WriteLine("Awaiting result from SendMessage Method");
            string msg = await sendMessage;
            Console.WriteLine("Async Method completed execution");
            Console.WriteLine("Current Time" + DateTime.Now);
            Console.WriteLine("Async Send Message" + sendMessage.Result);
            
        }
        static void Main(string[] args)
        {
            RecieveMessage();


            Console.ReadLine();
        }
    }
}
