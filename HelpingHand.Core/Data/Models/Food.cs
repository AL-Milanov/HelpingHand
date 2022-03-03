using System.ComponentModel.DataAnnotations;

namespace HelpingHand.Core.Data.Models
{
    public class Food
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Name { get; set; }

        public int Quantity { get; set; }
    }
}