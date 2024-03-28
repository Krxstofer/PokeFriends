using Microsoft.EntityFrameworkCore;
using PokeFriends.Models;

namespace PokeFriends.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<PokeClub> PokeClubs { get; set; }
        public DbSet<PokeMeetup> PokeMeetups { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
