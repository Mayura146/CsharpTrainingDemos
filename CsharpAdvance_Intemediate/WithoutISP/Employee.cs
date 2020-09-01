using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutISP
{
    interface IEmployee
    {
        void PaidLeaves();
        void SickLeaves();
        void PublicHolidays();
    }

    class PermanentEmployee : IEmployee
    {
        public void PaidLeaves()
        {
            Console.WriteLine("Permanent Employee can avail PaidLeave");
        }

        public void SickLeaves()
        {
            Console.WriteLine("Permanent Employee can avail Sick Leave");
        }
        public void PublicHolidays()
        {
            Console.WriteLine("Permanent Employee can avail PublicHolidays");
        }
    }

    class ContractEmployee : IEmployee
    {
        public void PaidLeaves()
        {
            Console.WriteLine("Contract Employee cannot avail PaidLeave");
        }

        public void SickLeaves()
        {
            Console.WriteLine("Contract Employee can avail Sick Leave");
        }
        public void PublicHolidays()
        {
            Console.WriteLine("Contract Employee can avail PublicHolidays");
        }
    }
}
