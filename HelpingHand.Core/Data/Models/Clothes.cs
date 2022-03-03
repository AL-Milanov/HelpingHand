using HelpingHand.Core.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace HelpingHand.Core.Data.Models
{
    public class Clothes
    {
        [Key]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(Constraints.CLOTHES_TYPE_MAX_LENGTH)]
        public string? Type { get; set; }

        [Required]
        [StringLength(Constraints.CLOTHES_SIZE_MAX_LENGTH)]
        public string? Size { get; set; }
    }
}