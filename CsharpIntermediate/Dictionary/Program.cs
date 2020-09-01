using System;
using static System.Console;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> employeeList = new Dictionary<int, string>();
            employeeList.Add(1, "Mayura");
            employeeList.Add(2, "Amit");
            employeeList.Add(3, "Ankit");
            employeeList.Add(4, "Alok");
            //employeeList.Add(2, "John");
            WriteLine($"Count {employeeList.Count}");
            WriteLine($" Contains Key {employeeList.ContainsKey(3)}");
            WriteLine($" Contains Key {employeeList.ContainsValue("Amit")}");

            WriteLine("Values in dictionary");
            foreach(KeyValuePair<int,string> employee in employeeList)
            {
                WriteLine("" + employee);
            }
            Dictionary<int, Employee> empList = new Dictionary<int, Employee>();
            Employee emp1 = new Employee()
            {
                employeeId = 1,
                employeeName = "Mayura",
                department = "SE"
            };
            Employee emp2 = new Employee()
            {
                employeeId = 2,
                employeeName = "ALok",
                department = "HR"
            };
            Employee emp3 = new Employee()
            {
                employeeId = 3,
                employeeName = "Sam",
                department = "Sales"
            };

            empList.Add(emp1.employeeId, emp1);
            empList.Add(emp2.employeeId, emp2);
            empList.Add(emp3.employeeId, emp3);
            foreach( var i in empList)
            {
                WriteLine($" Employee id :{i.Value.employeeId}");
                WriteLine($" Employee name :{i.Value.employeeName}");
                WriteLine($" Employee department :{i.Value.department}");
                WriteLine();
            }
            ReadLine();
        }
    }
}
