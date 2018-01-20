using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon.Entities
{
    public class Team
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsHome { get; set; }

        public virtual ICollection<Player> Players { get; set; }

        public virtual ICollection<Point> Points { get; set; }
    }
}
