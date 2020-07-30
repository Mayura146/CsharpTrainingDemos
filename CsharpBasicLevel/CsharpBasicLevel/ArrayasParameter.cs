using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpBasicLevel
{
    class ArrayasParameter
    {
        public int addValue(params int [] values)
        {
            int sum = 0;
            foreach(int i in values)
            {
                sum = sum + i;
            }
            return sum;
        }
    }
}
