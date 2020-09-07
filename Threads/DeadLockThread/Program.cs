using System;
using System.Threading;
namespace DeadLockThread
{

    public class Account
    {
        public int id { get; }
        private double balance;
        public Account(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }

        public void WithdrawMoney(double amount)
        {
            balance -= amount;
        }
        public void DepositMoney(double amount)
        {
            balance += amount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Main Thread Started!!!");
            Account account1001 = new Account(1001, 5000);
            Account account1002 = new Account(1002, 3000);
            AccountManagment accountManagment1 =
                new AccountManagment(account1001, account1002, 5000);

            AccountManagment accountManagment2 = new
                AccountManagment(account1002, account1001, 6000);
            Thread t1 = new Thread(accountManagment1.FundTranser)
            {
                Name = "Thread 1"
        };
            Thread t2 = new Thread(accountManagment2.FundTranser)
            {
                Name = "Thread 2"
            };
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();


            Console.WriteLine("Main Thread Completed");
            Console.ReadLine();
        }
    }
}


