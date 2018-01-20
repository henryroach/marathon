using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Marathon.Entities
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

        public virtual ICollection<Point> HomePlayerOnePoints { get; set; }
        public virtual ICollection<Point> HomePlayerTwoPoints { get; set; }
        public virtual ICollection<Point> GuestPlayerOnePoints { get; set; }
        public virtual ICollection<Point> GuestPlayerTwoPoints { get; set; }
    }
}
