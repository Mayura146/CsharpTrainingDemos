using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;
namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteLine("************Employee Details*********");
            // Method Syntax
            var employeeDetails = Employee.GetEmployees().ToList();

            // Query Syntax
                        var querySyntax = (from employee in Employee.GetEmployees()
                               select employee).ToList();
            foreach(var i in employeeDetails)
            {
                WriteLine("" + i.employeeId);
                WriteLine("" + i.employeeName);
            }
            WriteLine("***********display employee Id >45*********");
            List<int> employeeId = Employee.GetEmployees()
                .Where(employeeId => employeeId.employeeId > 45)
                .Select(x => x.employeeId).ToList();
            foreach(var i in employeeId)
            {
                WriteLine("" + i);
            }

            WriteLine("********Display Name,Location*******");
            List<Employee> employee1 = Employee.GetEmployees().
                Select(emp => new Employee()
            {
                employeeName = emp.employeeName,
                location = emp.location
            }).ToList();

            foreach(var i in employee1)
            {
                WriteLine("" + i.employeeName);
                WriteLine("" + i.location);
            }

            WriteLine("****display data whose salary >8k");

            var employee2 = Employee.GetEmployees().
                Where(x => x.salary > 8000 && x.location=="Pune").ToList();
            WriteLine(" EmployeeName,Location,Salary/12");
            var customProjection = Employee.GetEmployees().Where(x => x.salary > 10000)
                .Select(x => new Employee()
                {
                    employeeName = x.employeeName,
                    salary = x.salary / 12,
                    
              
                }).ToList();

            WriteLine("******Order by Ascending/Descending*****");
            List<Employee> orderBy = Employee.GetEmployees().
                OrderBy(s => s.employeeName).ToList();

            List<Employee> orderByDescending = Employee.GetEmployees().
                OrderByDescending(s => s.employeeName).ToList();

            List<Employee> filter = Employee.GetEmployees().
                Where(x => x.location == "Pune").
                OrderByDescending(x => x.employeeName).ToList();

            List<Employee> thenBy = Employee.GetEmployees()
                .OrderByDescending(x => x.employeeName)
                .ThenByDescending(x => x.location).
                Where(x => x.employeeId > 12).ToList();
            WriteLine("Sum function");
            int sumOfSalary = Employee.GetEmployees().
                Where(x => x.employeeId > 12).Sum(x => x.salary);

            var groupBy = Employee.GetEmployees().GroupBy(x => x.employeeName);
            WriteLine("****** Except Operator********");
            List<int> dataSource1 = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<int> dataSource2 = new List<int>() { 1, 3, 5, 8, 9, 10 };
            var except = (from source in dataSource1 select source)
                .Except(dataSource2).ToList();
            foreach(var i in except)
            {
                WriteLine("" + i);
            }

            WriteLine("Fetch Technologies");
            var technologies = Trainer.GetTrainerDetails().
                SelectMany(x => x.Technologies).ToList();
            WriteLine("****Unique Techonologies***");

            var uniqueTech = Trainer.GetTrainerDetails().
                SelectMany(x => x.Technologies).Distinct().ToList();

            WriteLine("*******SingleOrDefault********");
            //var employeeName = Employee.GetEmployees()
            //    .SingleOrDefault(x => x.employeeId > 10);
            WriteLine("FindLast");
            var findLast = Employee.GetEmployees().
                FindLast(x => x.employeeName == "Mayura");

            WriteLine("" + findLast.employeeId);
            var findAll = Employee.GetEmployees().
                FindAll(x => x.employeeName == "Mayura").ToList();
            WriteLine("enter Index to fetch the record");
            int id = Convert.ToInt32(ReadLine());
            var indexRecord = Employee.GetEmployees().ElementAt(id);
            WriteLine("Value is " + indexRecord.employeeName);
            WriteLine("Take");
            var take = Employee.GetEmployees().
                Where(x => x.employeeId > 12).Take(2).ToList();
            foreach(var i in take)
            {
                WriteLine("" + i.employeeId);
            }

            // Join, GroupJoin
            // Join / SelectMany()
            ReadLine();
        }
    }
}
