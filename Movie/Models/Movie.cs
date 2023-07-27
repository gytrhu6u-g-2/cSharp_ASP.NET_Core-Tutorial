using System;
using System.ComponentModel.DataAnnotations;

namespace Movie.Models
{
	public class Movie
	{
        public Movie()
        {
        }
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public decimal Revenue { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}

