using BlazorServer.BridgePatternExample.Domain.Models;

namespace BlazorServer.BridgePatternExample.Bridges
{
    public abstract class CardCostCalculator
    {
        protected OrderBase Order { get; set; }

        protected readonly ICardConditionPriceAdjustment CardConditionPriceAdjustment;
        public CardCostCalculator(OrderBase order, ICardConditionPriceAdjustment cardConditionPriceAdjustment)
        {
            Order = order;
            CardConditionPriceAdjustment = cardConditionPriceAdjustment;
        }

        public abstract int? CalculatePrice();
    }
}
