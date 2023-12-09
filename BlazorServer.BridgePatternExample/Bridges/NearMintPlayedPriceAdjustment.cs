namespace BlazorServer.BridgePatternExample.Bridges
{
    public class NearMintPlayedPriceAdjustment : ICardConditionPriceAdjustment
    {
        public double GetPriceModifier()
        {
            return 2.0;
        }
    }
}
