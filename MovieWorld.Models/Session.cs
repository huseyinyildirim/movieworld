using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MovieWorld.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }

        public int SaloonId { get; set; }

        [ForeignKey("SaloonId")]
        public virtual Saloon Saloon { get; set; }

        public int FilmId { get; set; }

        [ForeignKey("FilmId")]
        public virtual Film Film { get; set; }

        public List<DateTime> Sessions { get; set; }

        public enums.Dubbing Dubbing { get; set; }
    }
}
