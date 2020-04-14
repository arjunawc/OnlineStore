using Microsoft.AspNetCore.Identity;
using OnlineStore.Core.Entities.Identity;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
        public static async Task SeedUserAync(UserManager<AppUser> userManager)
        {
            if(!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "Arjuna",
                    Email = "arjuna@test.com",
                    UserName = "arjuna@test.com",
                    Address = new Address
                    {
                        FirstName = "Arjuna",
                        LastName = "Sumathiratne",
                        Street = "7th Street",
                        City = "New Yourk",
                        State = "NY",
                        Zipcode = "90210"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}
