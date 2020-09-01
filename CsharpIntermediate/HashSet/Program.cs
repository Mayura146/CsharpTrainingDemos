using System;
using static System.Console;
using System.Collections.Generic;
namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> hashSet = new HashSet<string>();
            hashSet.Add("Mayura");
            hashSet.Add("Sam");
            hashSet.Add("John");

            HashSet<string> hashSet1 = new HashSet<string>
            {
                "1",
                "2",
                "3",
                "Arun"
            };

            hashSet.Add("Sam");
            foreach(var i in hashSet)
            {
                WriteLine("" + i);
            }

            // Union

            hashSet.UnionWith(hashSet1);
            WriteLine("UnionWith=>");
            foreach(var i in hashSet)
            {
                WriteLine("" + i);
            }
            WriteLine("");
            // Intersect
            hashSet.IntersectWith(hashSet1);
            WriteLine("InterSectWith=>");
            foreach (var i in hashSet)
            {
                WriteLine("" + i);
            }
            // ExceptWith

            hashSet1.ExceptWith(hashSet);
            WriteLine("ExceptWith=>");
            foreach (var i in hashSet)
            {
                WriteLine("" + i);
            }

            HashSet<Customer> customerList = new HashSet<Customer>
            {
                new Customer {customerId=1,customerName="Mayura",location="Bangaloe"},
                new Customer{customerId=1,customerName="Mayura",location="Bangaloe" },
                new Customer {customerId=3,customerName="Sameer",location="Delhi"}
            };
            WriteLine("Customer Details");
            foreach(var customer in customerList)
            {
                WriteLine($"Customer Id :{customer.customerId}");
                WriteLine($"Customer Name :{customer.customerName}");
                WriteLine($"Customer Location :{customer.location}");
                WriteLine("");
            }
            ReadLine();
        }
        
    }
}
