using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
namespace WithISP
{
    class Employee
    {
        public int employeeId;
        public string employeeName;
        public string location;


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
            var eid = Employee.GetEmployees().Find(x => x.employeeId == empId);
            GetEmployees().Remove(eid);
            return true;


        }
        public static void SendEmail()
        {
            try
            {
                MailMessage mailMessage = new MailMessage();
                SmtpClient smtpClient = new SmtpClient();
                mailMessage.From = new MailAddress("mayura.sonar83@gmail.com");
                mailMessage.To.Add(new MailAddress("mayura.sonar@outlook.com"));
                mailMessage.Subject = "Single Responsibilty Demo";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "We will be discussing SOLID Principle";
                smtpClient.Port = 587;
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("mayura.sonar83@gmail.com",
                    "Mayura@123");
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMessage);
                Console.WriteLine("Email Sent Successfully");
            }

            catch(Exception e)
            {
                Console.WriteLine("Error occured" + e.Message);
            }
        }

    }
        class Program
    {
        static void Main(string[] args)
        {
           Employee.GetEmployees();
            bool result = Employee.DeleteEmployee(2);
            Employee.SendEmail();
            Console.WriteLine("Hello World!");
        }
    }
}
