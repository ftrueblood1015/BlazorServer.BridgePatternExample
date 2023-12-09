using System.ComponentModel.DataAnnotations;

namespace BlazorServer.BridgePatternExample.Domain.Models
{
    public class OrderBase : BaseModel
    {
        [Required]
        public int? ConditionId { get; set; }

        public Condition? Condition { get; set; }

        [Required]
        public int? CardId { get; set; }

        public Card? Card { get; set; }

        public string? Comments { get; set; }

        [Required]
        public int? TotalCost { get; set; }
    }
}
