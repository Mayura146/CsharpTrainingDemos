using System;

namespace WithoutOpenClosedPrincple
{
   public class PFCalculation

    {
        public double CalculatePF(double salary,string status)
        {
            double pF = 0;
            if(status=="Permanent")
            {
                pF = salary * 0.8;
            }

            else if(status=="Probabtion")
            {
                pF = salary * 0.6;
            }

            else
            {
                Console.WriteLine("Incorrect data");
            }
            return pF;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            PFCalculation pF = new PFCalculation();
            double result = pF.CalculatePF(4000, "Permanent");
            Console.WriteLine("Hello World!");
        }
    }
}
