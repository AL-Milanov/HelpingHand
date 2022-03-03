using System.ComponentModel.DataAnnotations;

namespace HelpingHand.Core.Data.Models
{
    public class Clothes
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public string? Type { get; set; }

        public string? Size { get; set; }
    }
}