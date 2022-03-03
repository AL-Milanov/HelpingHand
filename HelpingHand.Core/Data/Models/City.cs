using HelpingHand.Core.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HelpingHand.Core.Data.Models
{
    public class City
    {
        [Key]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(Constraints.CITY_NAME_MAX_LENGTH)]
        public string? Name { get; set; }

        [Required]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string? CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        public virtual Country? Country { get; set; }
    }
}