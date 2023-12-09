namespace BlazorServer.BridgePatternExample.Bridges
{
    public class HeavilyPlayedPriceAdjustment : ICardConditionPriceAdjustment
    {
        public double GetPriceModifier()
        {
            return 0.75;
        }
    }
}
