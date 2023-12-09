using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.BridgePatternExample.Repositories.Cards
{
    public class CardRepository : BaseRepository<Card, BridgePatternContext>, ICardRepository
    {
        public CardRepository(BridgePatternContext context) : base(context)
        {
        }

        public new IEnumerable<Card> GetAll()
        {
            return Context.Set<Card>().Include(t => t.CardType).Include(r => r.CardRarity).Include(i => i.ColorIdentity);
        }
    }
}
