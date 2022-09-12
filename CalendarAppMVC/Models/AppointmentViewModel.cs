using System;

namespace CalendarAppMVC
{
    public class AppointmentViewModel
    {
        internal DateTime startDate;
        internal DateTime finishDate;
        internal int duration;
        internal string title;
        internal string desc;
        internal string company;
        internal string owner;

        public AppointmentViewModel()
        {
        }
    }
}