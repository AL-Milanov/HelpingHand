using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHand.Core.Data.Models
{
    public class City
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Name { get; set; }

        public string? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
    }
}