namespace BlazorServer.BridgePatternExample.Bridges
{
    public class ModeratelyPlayedPriceAdjustment : ICardConditionPriceAdjustment
    {
        public double GetPriceModifier()
        {
            return .90;
        }
    }
}
