using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIntermediate
{
    class Savings:Account
    {

        public Savings() : base()
        {

        }

        public override bool Deposit(double Amount)
        {
          //  this.amount = Amount;
            balance = balance + Amount;
            Console.WriteLine($"Your Account balance is {balance}");
            return true;
        }

        public override bool WithDraw(double Amount)
        {
          //  this.amount = Amount;
            balance = balance - Amount;
            Console.WriteLine($"Your Account balance is {balance}");
            return true;
        }
    }
}
