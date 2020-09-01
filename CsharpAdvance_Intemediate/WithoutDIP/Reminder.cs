using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutDIP
{
    class Reminder
    {
        public DateTime startTime;
        public string title;
        public string description;
        public void StartReminder()
        {
            Console.WriteLine("Reminder Set");
        }
    }
}
