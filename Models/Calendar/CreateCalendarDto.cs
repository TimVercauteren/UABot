using System;
using System.Collections.Generic;
using System.Text;

namespace Models.Calendar
{
    public class CreateCalendarDto
    {
        public DateTime Tijdstip { get; set; }
        public string Difficulty { get; set; }
        public string Description { get; set; }
        public string RaidNaam { get; set; }
        public object User { get; set; }
    }
}
