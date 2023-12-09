using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Infrastructure;

namespace BlazorServer.BridgePatternExample.Repositories.CardRarities
{
    public class CardRarityRepository : BaseRepository<CardRarity, BridgePatternContext>, ICardRarityRepository
    {
        public CardRarityRepository(BridgePatternContext context) : base(context)
        {
        }
    }
}
