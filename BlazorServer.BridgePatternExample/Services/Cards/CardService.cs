using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.Cards;

namespace BlazorServer.BridgePatternExample.Services.Cards
{
    public class CardService : BaseService<Card, ICardRepository>, ICardService
    {
        public CardService(IBaseRepository<Card> repo) : base(repo)
        {
        }
    }
}
