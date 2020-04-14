using OnlineStore.Core.Entities.Identity;

namespace OnlineStore.Core.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
