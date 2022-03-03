using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHand.Core.Data.Models
{
    public class Shelter
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Address { get; set; }

        public byte Capacity { get; set; }

        public ushort Area { get; set; }

        public string? CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        public virtual City? City { get; set; }

        public string? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
    }
}