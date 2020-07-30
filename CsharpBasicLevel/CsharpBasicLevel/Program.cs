using System;
using static System.Console;


namespace CsharpBasicLevel
{
    /*
     * ways to sort in descending order
     * 1. Array.Reverse()
     * 2.ToCompare
     * 3.Delegate
     * 4. Using Linq descending
     * 5. Bubble sort
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            ArrayasParameter ap = new ArrayasParameter();
            int[] values = new int[] { 1, 2, 3, 4, 5, 6, 6, 6 };
            int output=ap.addValue(values);
            WriteLine($"OutPut is{output} ");

            WriteLine("Hello World!");

            //string[] EmployeeName = new string[5];

            ////  EmployeeName = new string[12];

            //WriteLine("Enter values for EmployeeName");
            //for(int i=0;i<EmployeeName.Length;i++)
            //{
            //    EmployeeName[i] = ReadLine();
            //}

            //WriteLine("Arrays values are");
            //foreach(string val in EmployeeName)
            //{
            //    WriteLine(val);
            //}

            WriteLine("****Array Methods");
            //Array.Sort(EmployeeName);
            //WriteLine("Sorting");
            //foreach (string val in EmployeeName)
            //{
            //    WriteLine(val);
            //}

            //WriteLine("*********Reverse*******");
            //Array.Reverse(EmployeeName);
            //WriteLine("Sorting");
            //foreach (string val in EmployeeName)
            //{
            //    WriteLine(val);
            //}
            WriteLine("Resize array with new lenght");
            int[] empid = new int[6] { 1, 34, 5, 0, 100, 89 };
            empid = new int[9];
            foreach(int i in empid)
            {
                WriteLine(i);
            }

            WriteLine("Sort value using Bubblesort!!");
            for(int i =0;i<empid.Length;i++)
            {
                for(int j=i+1;j<empid.Length;j++)
                {
                    // compare array element with all next element
                    if(empid[i]<empid[j])
                    {
                        int temp = empid[i];
                        empid[i] = empid[j];
                        empid[j] = temp;
                    }
                }
            }
            
            foreach(int val in empid)
            {
                WriteLine(val);
            }

            WriteLine("Array Copying");
            int[] arr = new int[3];
            Array.Copy(empid, arr, 3);
            WriteLine("New Array is");
            foreach (int val in arr)
            {
                WriteLine(val);
            }
            // Passing array as function parameter

            ReadLine();
        }
    }
}
