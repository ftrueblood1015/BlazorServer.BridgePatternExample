namespace BlazorServer.BridgePatternExample.Bridges
{
    public class LightlyPlayedPriceAdjustment : ICardConditionPriceAdjustment
    {
        public double GetPriceModifier()
        {
            return 1.0;
        }
    }
}
