using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWorld.Models
{
    public class Saloon
    {
        [Key]
        public int Id { get; set; }

        public int CinemaId { get; set; }

        [ForeignKey("CinemaId")]
        public virtual Cinema Cinema { get; set; }

        public string Name { get; set; }

        public int Capacity { get; set; }
    }
}
