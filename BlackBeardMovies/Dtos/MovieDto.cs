using BlackBeardMovies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BlackBeardMovies.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public byte NumberInStock { get; set; }

        public MovieDto(Movie newMovie)
        {
            this.Id = newMovie.Id;
            this.Name = newMovie.Name;
            this.GenreId = newMovie.GenreId;
            this.Genre = new GenreDto { Id = newMovie.Genre.Id, Name = newMovie.Genre.Name };
            this.NumberInStock = newMovie.NumberInStock;
        }

        public MovieDto()
        {

        }
    }
}