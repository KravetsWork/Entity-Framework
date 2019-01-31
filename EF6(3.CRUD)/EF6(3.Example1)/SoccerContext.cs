using System.Data.Entity;

namespace EF6_3.Example1_
{
    class SoccerContext : DbContext
    {
        public SoccerContext() : base("DefaultConnection") { }

        public DbSet<Player> Players { get; set; }
    }
}
