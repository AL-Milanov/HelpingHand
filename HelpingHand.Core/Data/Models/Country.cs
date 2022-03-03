using System.ComponentModel.DataAnnotations;

namespace HelpingHand.Core.Data.Models
{
    public class Country
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Name { get; set; }

        public virtual ICollection<City>? Cities { get; set; }

        public Country()
        {
            Cities = new HashSet<City>();
        }
    }
}