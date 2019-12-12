using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public class Raid
    {
        public DateTime Tijdstip { get; set; }
        public string Difficulty { get; set; }
        public string Description { get; set; }
        public List<Player> Accepted { get; set; }
        public List<Player> Declined { get; set; }
        public string RaidNaam { get; set; }
    }
}
