using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    public static class FakeEvents
    {
        public static Raid Event1()
        {
            return new Raid()
            {
                Description = "Gewoon mythic Eternal Palace",
                Tijdstip = new DateTime(2019, 12, 20, 20, 30, 00),
                Difficulty = "Mythic",
                RaidNaam = "Eternal Palace",
                Owner = "Thascorpion"
            };
        }
    }
}
