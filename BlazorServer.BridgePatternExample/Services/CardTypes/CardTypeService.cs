using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.CardTypes;

namespace BlazorServer.BridgePatternExample.Services.CardTypes
{
    public class CardTypeService : BaseService<CardType, ICardTypeRepository>, ICardTypeService
    {
        public CardTypeService(IBaseRepository<CardType> repo) : base(repo)
        {
        }
    }
}
