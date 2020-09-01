using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionMethods
{
    static class Extensionmethod
    {
        public static void Test2(this Program p, int a)
        {
            a = 4;
            Console.WriteLine("Method Tests2" + a);
        }
       /* 5= 5*4*3*2*1= */
       /* 5* Factorial(4)
        * 5*4*Factorial(3)
        */
       // 2*1=2

        public static int Factorial(this Int32 x)
        {
            if (x == 1 || x == 2)

                return x;
            else
                return x * Factorial(x - 1);
            
        }
    }
}
