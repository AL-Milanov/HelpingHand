using HelpingHand.Core.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHand.Core.Data.Models
{
    public class Shelter
    {
        [Key]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(Constraints.SHELTER_ADDRESS_MAX_LENGTH)]
        public string? Address { get; set; }

        [Range(Constraints.SHELTER_CAPACITY_MIN_VALUE,
            Constraints.SHELTER_CAPACITY_MAX_VALUE)]
        public byte Capacity { get; set; }

        [Range(Constraints.SHELTER_AREA_MIN_VALUE,
            Constraints.SHELTER_AREA_MAX_VALUE)]
        public ushort Area { get; set; }

        [Required]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string? CityId { get; set; }

        [ForeignKey(nameof(CityId))]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public virtual City? City { get; set; }

        [Required]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public virtual Country? Country { get; set; }
    }
}