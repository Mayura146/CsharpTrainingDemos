using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutDIP
{
    class Event
    {
        public DateTime startTime;
        public DateTime endTime;
        public string title;
        public string description;

        public void StartEvent()
        {
            Console.WriteLine("Even started");
        }
    }
}
