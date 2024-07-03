using System;
using ApplicationCore.Contracts.Services;
using ApplicationCore.Models.RequestModels;
using ApplicationCore.Models.ResponseModels;

namespace Infrastructure.Services
{
	public class AccountService: IAccountService
	{
		public AccountService()
		{
		}

        public Task<UserRegisterResponseModel> CreateUser(UserRegisterRequestModel requestModel)
        {
            throw new NotImplementedException();
        }

        public Task<UserLoginResponseModel> ValidateUser(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}

