using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWorld.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int Sort { get; set; }

        public bool IsActive { get; set; }
    }
}
