using System;
using System.Collections.Generic;
using static System.Console;
namespace SortedDet
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedSet<string> sortedSet = new SortedSet<string>();
            sortedSet.Add("Jan");
            sortedSet.Add("Feb");
            sortedSet.Add("December");
            sortedSet.Add("April");
         //   sortedSet.Add("April");

            WriteLine("Sorted Set is");
            foreach(var i in sortedSet)
            {
                WriteLine("" + i);
            }

            SortedSet<string> sortedSet2 = sortedSet.GetViewBetween("April", "Feb");
            WriteLine("Values between April and Jan");
            foreach (var i in sortedSet2)
            {
                WriteLine("" + i);
            }
           
            ReadLine();
        }
    }
}
