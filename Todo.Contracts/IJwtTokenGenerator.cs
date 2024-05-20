using Todo.Entities;

namespace Todo.Contracts
{
    public interface IJwtTokenGenerator
    {
        string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles);
    }
}
