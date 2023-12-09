using BlazorServer.BridgePatternExample.Bridges;
using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.PremiumOrders;
using BlazorServer.BridgePatternExample.Services.Cards;
using BlazorServer.BridgePatternExample.Services.Conditions;

namespace BlazorServer.BridgePatternExample.Services.PremiumOrders
{
    public class PremiumOrderService : BaseService<PremiumOrder, IPremiumOrderRepository>, IPremiumOrderService
    {
        IConditionService ConditionService;
        ICardService CardService;

        public PremiumOrderService(IBaseRepository<PremiumOrder> repo, IConditionService conditionService, ICardService cardService) : base(repo)
        {
            ConditionService = conditionService;
            CardService = cardService;
        }

        public new PremiumOrder Add(PremiumOrder order)
        {
            order.Condition = ConditionService.GetById((int)order.ConditionId!) ?? throw new Exception("Condition was not found!");
            order.Card = CardService.GetById((int)order.CardId!) ?? throw new Exception("Card was not found!");

            order.TotalCost = new MtgCardCostCalculator(order, new ModifierDecider(order).Decider()).CalculatePrice() + order.PricePremium;

            return Repo.Add(order);
        }
    }
}
