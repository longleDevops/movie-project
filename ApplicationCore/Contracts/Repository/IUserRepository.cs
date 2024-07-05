using System;
using ApplicationCore.Entities;

namespace ApplicationCore.Contracts.Repository
{
	public interface IUserRepository:IAsyncRepository<User>
	{
        //Return an entity user, but with Task since this is async method
        Task<User> GetUserByEmail(string email);
        Task<IEnumerable<Review>> GetReviewsByUser(int userId);
        Task<bool> CheckEmailExists(string email);
        Task<bool> CheckMoviePurchased(int userId, int movieId);
    }
}

