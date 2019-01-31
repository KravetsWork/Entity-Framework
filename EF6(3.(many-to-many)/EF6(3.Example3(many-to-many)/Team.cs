using System.Collections.Generic;

namespace EF6_3.Example3_many_to_many_
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Coach { get; set; }

        public virtual ICollection<Player> Players { get; set; }
        public Team()
        {
            Players = new List<Player>();
        }
    }
}
