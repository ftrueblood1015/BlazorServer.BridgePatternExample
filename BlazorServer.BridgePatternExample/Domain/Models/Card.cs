using System.ComponentModel.DataAnnotations;

namespace BlazorServer.BridgePatternExample.Domain.Models
{
    public class Card : BaseModel
    {
        [Required]
        public int? ConvertedManaCost { get; set; }

        [Required]
        public string? Set { get; set; }

        [Required]
        public int? CardTypeId { get; set; }

        public CardType? CardType { get; set; }

        [Required]
        public int? ColorIdentityId { get; set; }

        public ColorIdentity? ColorIdentity { get; set; }

        [Required]
        public int? CardRarityId { get; set;}

        public CardRarity? CardRarity { get; set;}

        public int? BaseCost { get; set;}
    }
}
