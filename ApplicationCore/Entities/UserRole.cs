using System;
using System.Data;

namespace ApplicationCore.Entities
{
	public class UserRole
	{
        // One user can have many roles and one role can be belong to many users
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public User User { get; set; } = null!;
        public Role Role { get; set; } = null!;
    }
}

