using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIntermediate
{
    class Current:Account
    {
        public double minBalance = 100000;
        private double dailywithdraw = 20000;

        public Current():base()
        {

        }

        public override bool Deposit(double Amount)
        {
            amount = Amount;
            this.balance = balance + amount;
            Console.WriteLine($"Your Balance is {balance}");
            return true;
        }

        public override bool WithDraw(double Amount)
        {
            amount = Amount;
            if(amount>balance)
            {
                Console.WriteLine("Your account has insufficient balance");
                return false;
            }

            else if( amount > dailywithdraw)
            {
                Console.WriteLine("You cannot withdraw more than 20k");
                return false;
            }

            else
            {
                balance = balance - amount;
                Console.WriteLine($"Your Balance is {balance}");
                return true;

            }
        }
    }
}
