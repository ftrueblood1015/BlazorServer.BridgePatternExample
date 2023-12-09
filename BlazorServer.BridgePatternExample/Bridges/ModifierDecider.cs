using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Pages.Orders;

namespace BlazorServer.BridgePatternExample.Bridges
{
    public class ModifierDecider
    {
        private OrderBase Order { get; set; }

        public ModifierDecider(OrderBase order)
        {
            Order = order;
        }

        public ICardConditionPriceAdjustment Decider()
        {
            switch (Order!.Condition!.Name)
            {
                default:
                    return new LightlyPlayedPriceAdjustment();
                case "Damaged":
                    return new DamagedPriceAdjustment();
                case "Heavily Played":
                    return new HeavilyPlayedPriceAdjustment();
                case "Moderately Played":
                    return new ModeratelyPlayedPriceAdjustment();
                case "Lightly Played":
                    return new LightlyPlayedPriceAdjustment();
                case "Near Mint":
                    return new NearMintPlayedPriceAdjustment();
                case "Mint":
                    return new MintPlayedPriceAdjustment();
            }
        }
    }
}
