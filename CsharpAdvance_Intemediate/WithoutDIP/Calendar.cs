using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutDIP
{
   public class Calendar
    {
        Event event1;
        Reminder reminder;

        public Calendar()
        {
            event1 = new Event();
            reminder = new Reminder();
        }

        public void Start()
        {
            event1.StartEvent();
            reminder.StartReminder();
        }

    }
}
