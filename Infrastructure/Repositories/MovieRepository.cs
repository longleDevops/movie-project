using System;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    // This class will implement the IRepository from the contracts
    // The generic type will be movie 
    public class MovieRepository : EfRepository<Movie>, IMovieRepository
    {
        public MovieRepository(MovieShopDbContext dbContext) : base(dbContext)
        {
        }

        // We do not need to implement all methods as the efRepository already implementing those methods
        public IEnumerable<Movie> GetTop30RevenueMovies()
        {
            // using linq and entity framwork to query
            var movies = _dbContext.Movies.OrderByDescending(m => m.Revenue).Take(30);
            return movies;
        }

        public override Movie GetByID(int id)
        {
            // First will throw exeption if id does not exist
            // FirstOrDefault safest, will be default value if id not exist
            // Single throws ex 0 or more than 1
            // SingleOrDefault throws ex if more than 1, if equal 0, will be the default value

            // include junction table first => include the actual table from genre => 
            var movieDetails = _dbContext.Movies.Include(m => m.GenresOfMovie).ThenInclude(m => m.Genre).Include(m=>m.Trailers).FirstOrDefault(m=>m.Id==id);

            return movieDetails;

        }


    }
} 

