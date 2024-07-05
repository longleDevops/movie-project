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

        


    }
} 

