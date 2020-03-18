using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWorld.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int TownId { get; set; }

        [ForeignKey("TownId")]
        public virtual Town Town { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }

        public string Mail { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }
    }
}
