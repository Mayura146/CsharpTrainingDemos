using System;
using System.Threading.Tasks;
namespace TaskReturnValue
{

    class Employee
    {
        public int id;
        public string name;
        public string location;
        public Employee(int id,string name,string location)
        {
            this.id = id;
            this.name = name;
            this.location = location;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Task<Employee> employee = Task.Run(() =>
            {
                Employee emp = new Employee(1, "Mayura", "Bangalore");
                return emp;
            });

            Employee e = employee.Result;
            Console.WriteLine($" ID {e.name}");
            Console.WriteLine("Main Thread Completed");
            Console.ReadLine();
        }
    }
}
