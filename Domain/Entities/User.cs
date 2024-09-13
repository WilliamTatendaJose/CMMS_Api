
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;
// User.cs (using Identity)
public class User : IdentityUser<int>
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public ICollection<UserRole> UserRoles { get; set; }     = new HashSet<UserRole>();
}

// Role.cs (using Identity)
public class Role : IdentityRole<int>
{
    public string? Description { get; set; }
    public ICollection<UserRole>? UserRoles { get; set; }
}

// UserRole.cs (using Identity)
public class UserRole : Microsoft.AspNetCore.Identity.IdentityUserRole<int>
{
    public User User { get; set; }
    public Role Role { get; set; }
}
