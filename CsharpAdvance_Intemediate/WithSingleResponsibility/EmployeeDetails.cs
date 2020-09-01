using System;
using System.Collections.Generic;
using System.Text;

namespace WithSingleResponsibility
{
    class EmployeeDetails
    {
        public static List<Employee> GetEmployees()
        {

            List<Employee> employeeList = new List<Employee>()
        {
            new Employee{employeeId=45,employeeName="John",location="Pune"},
            new Employee{employeeId=67,employeeName="Sam",location="US"},
            new Employee{employeeId=12,employeeName="Mayura",location="Bangalore"}
        };



            return employeeList;
        }

        public static bool DeleteEmployee(int empId)
        {
            var eid = EmployeeDetails.GetEmployees().Find(x => x.employeeId == empId);
            GetEmployees().Remove(eid);
            return true;


        }
    }
}
