namespace BlazorServer.BridgePatternExample.Bridges
{
    public class DamagedPriceAdjustment : ICardConditionPriceAdjustment
    {
        public double GetPriceModifier()
        {
            return 0.5;
        }
    }
}
