using System;
using static System.Console;
using System.Collections.Generic;
namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Jan");
            queue.Enqueue("Feb");
            queue.Enqueue("March");
            queue.Enqueue("April");

            WriteLine("Queue Data is");
            foreach(var i in queue)
            {
                WriteLine("" + i);
            }
            WriteLine($" Queue Holds value {queue.Contains("Feb")}");
            WriteLine($"Total count of queue is {queue.Count}");
            string[] array = new string[5];
            array[0] = "May";
            array[1] = "June";
            array[2] = "July";
            queue.CopyTo(array, 1);
            WriteLine("Array Elements are");
            foreach( var value in array)
            {
                WriteLine(" " + value);
            }
            // Hashcode
            WriteLine($"HashCode of queue is {queue.GetHashCode()}");
            WriteLine($" Get Type is {queue.GetType()}");
            WriteLine($" Peek {queue.Peek()}");
            queue.Dequeue();
            WriteLine("Queue Data is");
            foreach (var i in queue)
            {
                WriteLine("" + i);
            }
            ReadLine();
        }
    }
}

