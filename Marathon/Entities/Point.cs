using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Marathon.Entities
{
    public class Point
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("HomePlayerOne")]
        public int HomePlayerOneId { get; set; }

        [ForeignKey("HomePlayerTwo")]
        public int HomePlayerTwoId { get; set; }

        [ForeignKey("GuestPlayerTwo")]
        public int GuestPlayerOneId { get; set; }

        [ForeignKey("GuestPlayerTwo")]
        public int GuestPlayerTwoId { get; set; }

        [ForeignKey("GainTeam")]
        public int GainTeamId { get; set; }

        public int MatchId { get; set; }

        public Team GainTeam { get; set; }
        public virtual Player HomePlayerOne { get; set; }
        public virtual Player HomePlayerTwo { get; set; }
        public virtual Player GuestPlayerOne { get; set; }
        public virtual Player GuestPlayerTwo { get; set; }

        public DateTime Created { get; set; }
    }
}
