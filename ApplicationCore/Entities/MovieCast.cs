using System;
namespace ApplicationCore.Entities
{
	public class MovieCast
	{
        // primary keys for movie and cast
        public int MovieId { get; set; }
        public int CastId { get; set; }
        public string? Character { get; set; }

        // Navigation property
        public Movie Movie { get; set; } = null!;
        public Cast Cast { get; set; } = null!;
    }
}

