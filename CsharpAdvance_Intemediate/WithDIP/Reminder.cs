using System;
using System.Collections.Generic;
using System.Text;

namespace WithDIP
{
    class Reminder:ICalendar
    {
        public DateTime startTime;
        public string title;
        public string description;

        public void Start()
        {
            Console.WriteLine("Reminder Set");
        }
    }
}
