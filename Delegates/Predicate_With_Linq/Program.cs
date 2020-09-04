using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_With_Linq
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static List<Employee> GetAllEmployees()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{id=1,name="Mayura",salary=34566},
                new Employee{id=2,name="Priyanka",salary=7890},
                new Employee{id=4,name="Anurag",salary=12345 }
            };

            return employees;
        }

        public static bool GetEmployee(Employee emp)
        {
            return emp.id == 4;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Predicate<Employee> predicate = new Predicate<Employee>(Employee.GetEmployee);
            // 1st Way:
            Employee emp = Employee.GetAllEmployees().Find(id => predicate(id));
            // 2nd way
            Employee employee = Employee.GetAllEmployees().
                Find(delegate (Employee employee1)
                {
                    return employee1.id == 4;
                });
            // Predicate

            var employeeList = Employee.GetAllEmployees().FindAll(predicate);

           

            foreach( var i in employeeList)
            {
                Console.WriteLine("Employee Name" +i.name);
            }

            //func Delegate
            var emp1 = Employee.GetAllEmployees().
                Where(x => x.id > 2).Select(x => x.id);
            Console.ReadLine();
        }
    }
}
