using System;
namespace ApplicationCore.Entities
{
	public class Role
	{
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        // Navigation property
        public ICollection<UserRole> UsersOfRole { get; set; } = null!;
    }
}

