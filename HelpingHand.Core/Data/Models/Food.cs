using HelpingHand.Core.Data.Common;
using System.ComponentModel.DataAnnotations;

namespace HelpingHand.Core.Data.Models
{
    public class Food
    {
        [Key]
        [StringLength(Constraints.ID_GUID_LENGTH)]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [Required]
        [StringLength(Constraints.FOOD_NAME_MAX_LENGTH)]
        public string? Name { get; set; }

        [Range(Constraints.FOOD_QUANTITY_MIN_VALUE,
            Constraints.FOOD_QUANTITY_MAX_VALUE )]
        public int Quantity { get; set; }
    }
}