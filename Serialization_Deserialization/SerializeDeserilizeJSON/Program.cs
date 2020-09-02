
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
namespace SerializeDeserilizeJSON
{
    /*
     1. using NewtonSoft.json
     3rd party library
     2. JavascriptJSONSerializer
         */

        public class Employee
    {
        public int id;
        public string name;
        public string location;
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee { id = 1, name = "Mayura", location = "Pune" });
            employees.Add(new Employee { id = 2, name = "Shilpa", location = "Bangalore" });

            FileStream fileStream = new FileStream("C:\\Training_Content\\JSONFILE.json", 
                FileMode.Create);

            string json = JsonConvert.SerializeObject(employees);
            StreamWriter sw = new StreamWriter(fileStream);
            sw.Write(json);
            sw.Close();
            fileStream.Close();

            List<Employee> emp = JsonConvert.DeserializeObject
                <List<Employee>>(json);
            Console.WriteLine("Deserialize Data");
            foreach( var i in emp)
            {
                Console.WriteLine($"Name {i.name}");
            }
            Console.ReadLine();
        }
    }
}
