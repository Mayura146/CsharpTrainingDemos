using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample
{
    class Trainer
    {
        public int Tid { get; set; }

        public string Tname { get; set; }

        public string Tlocation { get; set; }

        public List<string> Technologies { get; set; }

        public static List<Trainer> GetTrainerDetails()
        {
            List<Trainer> trainer = new List<Trainer>();

            trainer.Add(new Trainer
            {
                Tid = 1,
                Tname = "Poorva",
                Tlocation = "Pune",
                Technologies = new List<string> { "C", "C++", "Java", "WPF" }
            });
            trainer.Add(new Trainer
            {
                Tid = 2,
                Tname = "Tushar",
                Tlocation = "Mumbai",
                Technologies = new List<string> { "C#", "ASP.NET", "C", "WPF" }
            });
            trainer.Add(new Trainer
            {
                Tid = 3,
                Tname = "Heda",
                Tlocation = "Delhi",
                Technologies = new List<string> { "ETL", "C#" }
            });


            return trainer;
        }
    }
}

