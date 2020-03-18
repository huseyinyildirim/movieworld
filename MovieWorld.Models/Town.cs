using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWorld.Models
{
    public class Town
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public virtual City Cities { get; set; }
    }
}
