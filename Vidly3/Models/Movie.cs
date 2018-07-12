using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vidly3.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public Genre Genre { get; set; }

        [Required]
        [Display(Name="Genre")]
        public int GenreId { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        [Column(TypeName = "datetime2")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [Display(Name = "Date Added")]
        [Column(TypeName = "datetime2")]
        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name="Number In Stock")]
        [NumberInStock1To20]
        public byte NumberInStock { get; set; }
    }
}