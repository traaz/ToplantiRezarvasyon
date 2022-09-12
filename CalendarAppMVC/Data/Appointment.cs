using System;

namespace CalendarAppMVC.Data
{
    public class Appointment
    {
        
        
            public int roomID { get; set; } 
            public DateTime startDate { get; set; }
            public DateTime finishDate { get; set; }
            public int duration { get; set; }
            public string title { get; set; }
            public string desc { get; set; }
            public string company { get; set; }
            public string owner { get; set; }
            
           


        
    }
}