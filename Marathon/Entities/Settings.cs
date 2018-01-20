using System;
using System.ComponentModel.DataAnnotations;

namespace Marathon.Entities
{
    public class Settings
    {
        [Key]
        public int Id { get; set; }

        public DateTime? MarathonStart { get; set; }

        public int? ActualHomePlayerOne { get; set; }
        public int? ActualHomePlayerTwo { get; set; }
        public int? ActualGuestPlayerOne { get; set; }
        public int? ActualGuestPlayerTwo { get; set; }
    }
}
