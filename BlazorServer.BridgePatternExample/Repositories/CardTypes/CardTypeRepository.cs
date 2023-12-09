using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Infrastructure;

namespace BlazorServer.BridgePatternExample.Repositories.CardTypes
{
    public class CardTypeRepository : BaseRepository<CardType, BridgePatternContext>, ICardTypeRepository
    {
        public CardTypeRepository(BridgePatternContext context) : base(context)
        {
        }
    }
}
