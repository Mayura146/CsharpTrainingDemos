using System;
using System.Collections.Generic;
using System.Text;

namespace GenericDelegate
{
    class Demo
    {
        public static double AddNumber(int a ,float b,double c)
        {
            return a + b + c;
        }

        public static void AddNumber1(int a ,float b,double c)
        {
            Console.WriteLine(a + b + c);
        }

        public static bool CheckString(string name)
        {
            if (name.Length > 5)
            {
                return true;
            }

            else
                return false;
        }
    }
}
