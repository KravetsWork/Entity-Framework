﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6_3.Example2_one_to_many_
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }

        public int? TeamId { get; set; }
        public virtual Team Team { get; set; }

    }
}
