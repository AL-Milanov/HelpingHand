using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHand.Core.Data.Models
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; } = true;

        public virtual ICollection<Shelter>? Shelter { get; set; }

        public virtual ICollection<Food>? FoodSupplies { get; set; }

        public virtual ICollection<Clothes>? ClothesSupplies { get; set; }

        public string? CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City? City { get; set; }

        public string? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }

        public User()
        {
            Shelter = new HashSet<Shelter>();
            FoodSupplies = new HashSet<Food>();
            ClothesSupplies = new HashSet<Clothes>();
        }
    }
}
