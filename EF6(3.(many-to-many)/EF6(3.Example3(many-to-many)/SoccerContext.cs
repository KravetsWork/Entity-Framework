using System.Data.Entity;

namespace EF6_3.Example3_many_to_many_
{
    class SoccerContext : DbContext
    {
        public SoccerContext() : base("SoccerDb2")
        { }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
