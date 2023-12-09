namespace BlazorServer.BridgePatternExample.Bridges
{
    public class MintPlayedPriceAdjustment : ICardConditionPriceAdjustment
    {
        public double GetPriceModifier()
        {
            return 3.0;
        }
    }
}
