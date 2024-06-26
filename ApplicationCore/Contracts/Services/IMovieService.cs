using System;
using ApplicationCore.Models;

namespace ApplicationCore.Contracts.Services
{
	public interface IMovieService
	{
		// Have all the bussiness logic related to movies
		List<MovieCardModel> GetTop30GrossingMovies();

	}
}

