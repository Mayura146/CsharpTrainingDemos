using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIntermediate
{
  abstract  class Account
    {
        public string custName;
        public DateofBirth DOB;
        public double balance;
        protected string accType;
        public double amount;
        public abstract bool Deposit(double Amount);
        public abstract bool WithDraw(double Amount);

        public Account(string name,DateofBirth dateofbirth,double balance)
        {
            custName = name;
            DOB = dateofbirth;
            this.balance = balance;
        }

        protected Account()
        {

        }
        public string GetaccType()
        {
            accType = Console.ReadLine();
            return accType;
        }

        public void DisplayAccountDeatils()
        {
            Console.WriteLine($"Customer Name {custName}");
            Console.WriteLine($"Customer DOB {DOB}");
            Console.WriteLine($" Balance {balance}");

        }
    }
}
