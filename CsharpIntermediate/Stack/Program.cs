using System;
using System.Collections.Generic;
namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Stack<string> stack1 = new Stack<string>();
            Console.WriteLine(" Equals" + stack.Equals(stack1));
            stack.Pop();
            foreach(var i in stack)
            {
                Console.WriteLine("" + i);
            }
            Console.ReadLine();
        }
    }
}





// different ways to write Linq query

  