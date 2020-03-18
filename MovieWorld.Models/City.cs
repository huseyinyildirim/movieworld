using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWorld.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Plate { get; set; }

        public virtual ICollection<Town> Towns { get; set; }
    }
}
