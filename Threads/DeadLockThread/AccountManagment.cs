using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DeadLockThread
{
    class AccountManagment
    {
        private Account FromAccount;
        private Account ToAccount;
        private double transferAmount;

        public AccountManagment(Account from,Account to, double transferAmount)
        {
            FromAccount = from;
            ToAccount = to;
            this.transferAmount = transferAmount;
        }

        public void FundTranser()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} " +
                $"trying to acquire lock on {FromAccount.id}");

            lock(FromAccount)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on" +
                    $" {FromAccount.id}");
                Console.WriteLine($"{Thread.CurrentThread.Name}" +
                    $" acquired lock on {FromAccount.id}");
                Console.WriteLine($" {Thread.CurrentThread.Name} started Working");
                Thread.Sleep(2000);
                Console.WriteLine($"{Thread.CurrentThread.Name} trying to acquire lock on" +
               $" {ToAccount.id}");

                if (Monitor.TryEnter(ToAccount, 30000))
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} acquired lock on {ToAccount.id}");
                    try
                    {
                        FromAccount.WithdrawMoney(transferAmount);
                        ToAccount.DepositMoney(transferAmount);
                    }

                    finally
                    {
                        Monitor.Exit(ToAccount);
                    }
                }
                else
                {
                    Console.WriteLine($" {Thread.CurrentThread.Name} Unable to acquire lock on " +
                        $"{ToAccount.id}, so leaving!!");
                }
                }
                //lock (ToAccount)
                //{
                
                    //FromAccount.WithdrawMoney(transferAmount);
                    //ToAccount.DepositMoney(transferAmount);
                
            }


        }
    }
