using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository
{
	// Implement all methods for movie
	public interface IMovieRepository: IRepository<Movie>
	{
        IEnumerable<Movie> GetTop30RevenueMovies();
	}
}

