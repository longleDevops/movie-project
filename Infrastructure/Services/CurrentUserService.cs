using System;
using System.Security.Claims;
using ApplicationCore.Contracts.Services;

namespace Infrastructure.Services
{
	public class CurrentUserService: ICurrentUserService
	{
		public CurrentUserService()
		{
		}

        public int UserId => throw new NotImplementedException();

        public bool IsAuthenticated => throw new NotImplementedException();

        public string UserName => throw new NotImplementedException();

        public string FullName => throw new NotImplementedException();

        public string Email => throw new NotImplementedException();

        public string RemoteIpAddress => throw new NotImplementedException();

        public IEnumerable<string> Roles => throw new NotImplementedException();

        public string ProfilePictureUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsAdmin => throw new NotImplementedException();

        public bool IsSuperAdmin => throw new NotImplementedException();

        public IEnumerable<Claim> GetClaimsIdentity()
        {
            throw new NotImplementedException();
        }
    }
}

