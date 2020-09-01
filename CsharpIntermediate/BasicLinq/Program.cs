using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            // Query syntax
            var queryResult = from list1 in list where list1 > 2 select list1;
            foreach (var i in queryResult)
            {
                Console.WriteLine("" + i);
            }
            // method Syntax;
            Console.WriteLine("Method sytax");
            var methodSyntax = list.Where(list2 => list2 > 2).ToList();
            foreach (var i in methodSyntax)
            {
                Console.WriteLine("" + i);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
