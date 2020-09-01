using System;
using System.Collections.Generic;
using System.Text;

namespace WithOCP
{
   public abstract class CalculatePF
    {
        public abstract void PFCalculation(double salary, string status);
        public double totalPF = 0;
    }

    public class Permanent : CalculatePF
    {
        public override void PFCalculation(double salary, string status)
        {
            totalPF = salary * 0.8;
            Console.WriteLine($"PF calculation is {totalPF}");
        }
    }

    public class Probation : CalculatePF
    {
        public override void PFCalculation(double salary, string status)
        {
            throw new NotImplementedException();
        }
    }

    public class Contract : CalculatePF
    {
        public override void PFCalculation(double salary, string status)
        {
            totalPF = salary * 0.3;
        }
    }
}
