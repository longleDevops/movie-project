using System;
using ApplicationCore.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
	public class MovieShopDBContext: DbContext
	{
		public MovieShopDBContext(DbContextOptions<MovieShopDBContext> options) : base(options)
		{

		}

		public DbSet<Genre> Genres { get; set; }
	}
}

