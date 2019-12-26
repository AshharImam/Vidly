using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime AddedDate { get; set; }

        [Required]
        public byte InStock { get; set; }

        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
    }


}