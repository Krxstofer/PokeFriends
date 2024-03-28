using System.ComponentModel.DataAnnotations;

namespace PokeFriends.Models
{
    public class AppUser
    {
        [Key]
        public string Id { get; set; }
        public string? FavoritePokemon { get; set; }
        public string? ProfileImageUrl { get; set; }
        public Address? Address { get; set; }
        public ICollection<PokeClub> PokeClubs { get; set; }
        public ICollection<PokeMeetup> PokeMeetups { get; set; }
    }
}
