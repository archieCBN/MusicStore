using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Track
    {
        public int ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Album { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string Performer { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z'\s]*$")]
        [Required]
        [StringLength(40)]
        public string Genre { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }

    public class TrackDBContext : DbContext
    {
        public DbSet<Track> Tracks { get; set; }
    }
}