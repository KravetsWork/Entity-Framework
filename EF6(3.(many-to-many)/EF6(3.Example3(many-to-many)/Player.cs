using System.Collections.Generic;

namespace EF6_3.Example3_many_to_many_
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual ICollection<Team> Teams { get; set; }
        public Player()
        {
            Teams = new List<Team>();
        }
    }
}
