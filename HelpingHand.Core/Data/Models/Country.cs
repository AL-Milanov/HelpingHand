using HelpingHand.Core.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace HelpingHand.Core.Data.Models
{
    public class Country
    {
        [Key]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(Constraints.COUNTRY_NAME_MAX_LENGTH)]
        public string? Name { get; set; }

        public virtual ICollection<City>? Cities { get; set; }

        public Country()
        {
            Cities = new HashSet<City>();
        }
    }
}