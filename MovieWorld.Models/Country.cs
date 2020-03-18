using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWorld.Models
{
    public class Country
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }
    }
}
