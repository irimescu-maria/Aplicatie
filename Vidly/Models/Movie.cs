using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Display(Name="Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime DateAdded{ get; set; }

        [Display(Name="Number In Stock")]
        [Range(1,20)]
        [RangeNumberInStock]
        public byte NumberInStock { get; set; }

        public byte NumberAvailable { get; set; }
                                   
        //Navigation property

        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }



    }
}