using Microsoft.AspNetCore.Identity;
using PokeFriends.Data.Enum;
using PokeFriends.Models;
using System.Diagnostics;

namespace PokeFriends.Data
{
    public class Seed
    {
        public static void SeedData(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<ApplicationDbContext>();

                context.Database.EnsureCreated();

                if (!context.PokeClubs.Any())
                {
                    context.PokeClubs.AddRange(new List<PokeClub>()
                    {
                        new PokeClub()
                        {
                            Title = "Pokemon Club 1",
                            Image = "https://editors.dexerto.com/wp-content/uploads/2023/11/15/Pokemon-TCG-Charmander.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            PokeClubCategory = PokeClubCategory.Fire,
                            Address = new Address()
                            {
                                Street = "324 W Main st",
                                City = "Emporia",
                                State = "VA"
                            }
                         },
                        new PokeClub()
                        {
                            Title = "Pokemon Club 2",
                            Image = "https://editors.dexerto.com/wp-content/uploads/2023/11/15/Pokemon-TCG-Charmander.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            PokeClubCategory = PokeClubCategory.Ice,
                            Address = new Address()
                            {
                                Street = "834 Mister Rd",
                                City = "Richmond",
                                State = "VA"
                            }
                        },
                        new PokeClub()
                        {
                            Title = "Pokemon Club 3",
                            Image = "https://editors.dexerto.com/wp-content/uploads/2023/11/15/Pokemon-TCG-Charmander.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            PokeClubCategory = PokeClubCategory.Water,
                            Address = new Address()
                            {
                                Street = "435",
                                City = "Arlington",
                                State = "VA"
                            }
                        },
                        new PokeClub()
                        {
                            Title = "Pokemon Club 4",
                            Image = "https://editors.dexerto.com/wp-content/uploads/2023/11/15/Pokemon-TCG-Charmander.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first club",
                            PokeClubCategory = PokeClubCategory.Poison,
                            Address = new Address()
                            {
                                Street = "245 Adelphi Rd",
                                City = "Virginia Beach",
                                State = "VA"
                            }
                        }
                    });
                    context.SaveChanges();
                }
                //Races
                if (!context.PokeMeetups.Any())
                {
                    context.PokeMeetups.AddRange(new List<PokeMeetup>()
                    {
                        new PokeMeetup()
                        {
                            Title = "Pokemon Meetup 1",
                            Image = "https://i.pinimg.com/564x/6e/d1/7d/6ed17d914743c230e634b29a1753c4f8.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first meet",
                            PokeMeetupCategory = PokeMeetupCategory.Public,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        },
                        new PokeMeetup()
                        {
                            Title = "Pokemon Meetup 2",
                            Image = "https://i.pinimg.com/564x/6e/d1/7d/6ed17d914743c230e634b29a1753c4f8.jpg?quality=82&strip=1&resize=640%2C360",
                            Description = "This is the description of the first meet",
                            PokeMeetupCategory = PokeMeetupCategory.Private,
                            AddressId = 5,
                            Address = new Address()
                            {
                                Street = "123 Main St",
                                City = "Charlotte",
                                State = "NC"
                            }
                        }
                    });
                    context.SaveChanges();
                }
            }
        }

       /* public static async Task SeedUsersAndRolesAsync(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                //Roles
                var roleManager = serviceScope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

                if (!await roleManager.RoleExistsAsync(UserRoles.Admin))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.Admin));
                if (!await roleManager.RoleExistsAsync(UserRoles.User))
                    await roleManager.CreateAsync(new IdentityRole(UserRoles.User));

                //Users
                var userManager = serviceScope.ServiceProvider.GetRequiredService<UserManager<AppUser>>();
                string adminUserEmail = "teddysmithdeveloper@gmail.com";

                var adminUser = await userManager.FindByEmailAsync(adminUserEmail);
                if (adminUser == null)
                {
                    var newAdminUser = new AppUser()
                    {
                        UserName = "teddysmithdev",
                        Email = adminUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAdminUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAdminUser, UserRoles.Admin);
                }

                string appUserEmail = "user@etickets.com";

                var appUser = await userManager.FindByEmailAsync(appUserEmail);
                if (appUser == null)
                {
                    var newAppUser = new AppUser()
                    {
                        UserName = "app-user",
                        Email = appUserEmail,
                        EmailConfirmed = true,
                        Address = new Address()
                        {
                            Street = "123 Main St",
                            City = "Charlotte",
                            State = "NC"
                        }
                    };
                    await userManager.CreateAsync(newAppUser, "Coding@1234?");
                    await userManager.AddToRoleAsync(newAppUser, UserRoles.User);
                }
            }
        } */
    }
}

