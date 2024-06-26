﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApplicationCore.Entities
{
	[Table("Genre")]
	public class Genre
	{
        public int Id { get; set; }

        [MaxLength(24)] public string Name { get; set; } = null!;

        public ICollection<MovieGenre> MoviesOfGenre { get; set; } = null!;
    }
}

