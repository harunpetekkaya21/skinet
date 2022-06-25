using Core.Entities.Identity;
using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Identity
{
    public class AppIdentityDbContextSeed
    {
         public static async Task SeedUsersAsync(UserManager<AppUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                var user = new AppUser
                {
                    DisplayName = "harun",
                    Email = "harun@test.com",
                    UserName = "harun@test.com",
                    Address = new Address
                    {
                        FirstName = "harun",
                        LastName = "petekkaya",
                        Street = "kltr",
                        City = "Antalya",
                        State = "Kultur",
                        ZipCode = "07000"
                    }
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
            }
        }
    }
}