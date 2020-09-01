using System;
using static System.Console;
using System.Linq;
namespace LINQJOINs
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine(" INNER JOIN");

            var innerJoin = Employee.GetEmployees()// outer data Source
                .Join(Address.GetAlladdress(),// Inner data Source

                employee => employee.addressId,// outer 
                address => address.addressId,
                (employee, address) => new
                {
                    EmployeeName = employee.empName,
                    AddressLine = address.addressLine
                }

                ).ToList();

            foreach(var i in innerJoin)
            {
                WriteLine($"Employee Name {i.EmployeeName} => Address :{i.AddressLine}");
            }

            WriteLine("*********LEFT JOIN Method Syntax**********");

            var leftJoin = Employee.GetEmployees().
                GroupJoin(Address.GetAlladdress(),
                employee => employee.addressId,
            address => address.addressId,
            (employee, address) => new { employee, address }).
            SelectMany(x => x.address.DefaultIfEmpty(),
            (employee, address) => new
            {
                EmployeeName = employee.employee.empName,
                Address = address == null ? "Address not Mentioned" : address.addressLine
            });
           
            foreach(var i in leftJoin)
            {
                WriteLine($"Employee Name {i.EmployeeName} => Address :{i.Address}");

            }

            WriteLine("*********LEFT JOIN Query Syntax**********");

            var leftJoin1 = from employee in Employee.GetEmployees()
                            join address in Address.GetAlladdress() on
                            employee.addressId equals address.addressId into
                            EmployeeAddressGroup
                            from address1 in
       EmployeeAddressGroup.DefaultIfEmpty()
                            select new
                            {
                                EmployeeName = employee.empName,
                                Address = address1 == null ? "Address not Mentioned"
                                : address1.addressLine
                            };
            foreach (var i in leftJoin1)
            {
                WriteLine($"Employee Name {i.EmployeeName} => Address :{i.Address}");
            }
            WriteLine("************CROSS JOIN with SELECT MANY **********");
            var crossJoin = Employee.GetEmployees().
                SelectMany(address => Address.GetAlladdress(), (employee, address) => new
                {
                    EmployeeName = employee.empName,
                    Address = address.addressLine
                }
                );

            WriteLine("***********CROSS JOIN with Join method**********");
            var crossJoin1 = Employee.GetEmployees().Join(Address.GetAlladdress(),
                employee => false,
                address => false, (employee, address) => new
                {
                    EmployeeName = employee.empName,
                    Address = address.addressLine
                }
                );

            foreach( var i in crossJoin1)
            {
                WriteLine($" Employee Name : {i.EmployeeName} , Address :{i.Address}");
            }
            WriteLine(" CROSS JOIN QUERY SYNTAX******");
            var crossJoin2 = from employee in Employee.GetEmployees()
                             from address in Address.GetAlladdress()
                             select new
                             {
                                 EmployeeName = employee.empName,
                                 Address = address.addressLine
                             };
            foreach (var i in crossJoin2)
            {
                WriteLine($" Employee Name : {i.EmployeeName} , Address :{i.Address}");
            }
        }

       
        
    }
}
