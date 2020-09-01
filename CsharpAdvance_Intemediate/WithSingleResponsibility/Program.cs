using System;
using static System.Console;
namespace WithSingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeDetails.GetEmployees();
            EmailNotification.SendEmail();
            Console.ReadLine();
        }
    }
}
