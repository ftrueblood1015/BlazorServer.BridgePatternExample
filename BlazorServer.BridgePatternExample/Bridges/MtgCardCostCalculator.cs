using BlazorServer.BridgePatternExample.Domain.Models;

namespace BlazorServer.BridgePatternExample.Bridges
{
    public class MtgCardCostCalculator : CardCostCalculator
    {
        public MtgCardCostCalculator(OrderBase Order, ICardConditionPriceAdjustment cardConditionPriceAdjustment) : base(Order, cardConditionPriceAdjustment)
        {
        }

        public override int? CalculatePrice()
        {
            return (int?)((double)Order.Card!.BaseCost! * CardConditionPriceAdjustment.GetPriceModifier());
        }
    }
}
