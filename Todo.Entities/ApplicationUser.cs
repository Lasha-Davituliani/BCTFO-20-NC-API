using Microsoft.AspNetCore.Identity;

namespace Todo.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime LastActivity { get; set; }
    }
}
