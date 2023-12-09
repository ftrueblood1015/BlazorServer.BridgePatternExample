using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.CardRarities;

namespace BlazorServer.BridgePatternExample.Services.CardRarities
{
    public class CardRarityService : BaseService<CardRarity, ICardRarityRepository>, ICardRarityService
    {
        public CardRarityService(IBaseRepository<CardRarity> repo) : base(repo)
        {
        }
    }
}
