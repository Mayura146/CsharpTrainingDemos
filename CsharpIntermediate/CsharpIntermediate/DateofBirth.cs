using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpIntermediate
{
    class DateofBirth
    {
        public int day;
        public int month;
        public int year;

        public DateofBirth()
        {

        }

        public void AssignValue(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }


        public bool DateValidation()
        {
            if (day > 31 || month >12 || year<1962)
            {
                Console.WriteLine("Please enter valid date");
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool displayDate()
        {
            if(DateValidation()==true)
            {
                Console.WriteLine($" {day} {month} {year}");
                return true;
            }

            else
            {
                Console.WriteLine("Please enter date again");
                return false;
            }
        }
    }
}
