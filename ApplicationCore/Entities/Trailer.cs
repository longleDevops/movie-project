using System;
namespace ApplicationCore.Entities
{
	public class Trailer
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string TrailerUrl { get; set; } = null!;

        // reference to the movie id
        public int MovieId { get; set; }

        // navigation property
        public Movie Movie { get; set; } = null!;

    }
}

