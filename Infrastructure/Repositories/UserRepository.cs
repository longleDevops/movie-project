using System;
using ApplicationCore.Contracts.Repository;
using ApplicationCore.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
	public class UserRepository: EfRepository<User>, IUserRepository
	{
		public UserRepository(MovieShopDbContext dbContext) : base(dbContext)
		{
		}

        public Task<bool> CheckEmailExists(string email)
        {
            throw new NotImplementedException();
        }

        public Task<bool> CheckMoviePurchased(int userId, int movieId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Review>> GetReviewsByUser(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            var result = await _dbContext.Users.Include(u=>u.RolesOfUser).FirstOrDefaultAsync(u=> u.Email==email);
            return result;
        }
    }
}

