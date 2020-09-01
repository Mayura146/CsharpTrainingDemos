using System;
using System.Collections;
namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<string> list = new List<string>();
            //list.Add(2);
            
            ArrayList al = new ArrayList();
           // ArrayList a2 = new ArrayList();
            Console.WriteLine($"Capacity of an Array list is {al.Capacity}");
            al.Add(100);
            al.Add(12);
            al.Add(1);
            al.Add(45);
            ArrayList a = new ArrayList();
            a.Add(1);
            a.Add(2);
            a.Add(3);
            al.AddRange(a);
            al.Sort();
            Console.WriteLine("ArrayList after sort");
            foreach (var i in al)
            {
                Console.WriteLine(" " + i);
            }
            Console.WriteLine("ArrayList after adding new values");
            foreach(var i in al)
                {
                Console.WriteLine(" " + i);
            }

          ArrayList a2= (ArrayList)al.Clone();
            Console.WriteLine("Clone Array is");
            foreach (var i in a2) 
            {
                Console.WriteLine("" + i);
            }


            Console.WriteLine("Element in array" + al.Contains(12));
            Console.WriteLine($"Capacity of an Array list is {al.Capacity}");
            Console.WriteLine($"Count in ArrayList  is {al.Count}");
            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}


