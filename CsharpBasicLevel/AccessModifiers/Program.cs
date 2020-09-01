using System;

namespace AccessModifiers
{
    class Program
    {
        protected private string empname;
        protected private string Location;
        protected void GetempDetails()
        {
            Console.WriteLine($"name is {empname}");
            Console.WriteLine($"Location is {Location}");
        }
    
      
    }
  class Demo:Program
    {
        static void Main(string[] args)
        {
            Demo p = new Demo();
            p.empname = "Mayura";
            p.Location = "Bangalore";
        }
    }
   
}
