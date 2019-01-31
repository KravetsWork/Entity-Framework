﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_3.Example2_one_to_many_
{
    class SoccerContext : DbContext
    {
        public SoccerContext() : base("SoccerDb") { }

        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
    }
}
