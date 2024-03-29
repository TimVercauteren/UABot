﻿using System;
using System.Data.Entity;

namespace Database
{
    public class EntityContext : DbContext
    {
        public DbSet<Player> Players { get; set; }
        public DbSet<Raid> Raids { get; set; }
    }
}
