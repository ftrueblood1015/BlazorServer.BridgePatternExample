using System.ComponentModel.DataAnnotations;

namespace BlazorServer.BridgePatternExample.Domain.Models
{
    public class PremiumOrder : OrderBase
    {
        [Required]
        public string? Reason { get; set; }

        [Required]
        public int? PricePremium { get; set; }
    }
}
