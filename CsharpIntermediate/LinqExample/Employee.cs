using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample
{
  public class Employee
    {
        public int employeeId;
        public string employeeName;
        public int salary;
        public string location;

        public static List<Employee> GetEmployees()
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee { employeeId = 1, employeeName = "Mayura", salary = 34566, location = "Bangalore" });
            employeeList.Add(new Employee { employeeId = 45, employeeName = "John", salary = 56789, location = "US" });
            employeeList.Add(new Employee { employeeId = 78, employeeName = "Sam", salary = 87654, location = "Pune" });
            employeeList.Add(new Employee { employeeId = 12, employeeName = "Geeta", salary = 9865, location = "Mumbai" });
            employeeList.Add(new Employee { employeeId = 14, employeeName = "Mayura", salary = 9865, location = "Mumbai" });
            return employeeList;
        }
    }
}
