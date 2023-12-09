using BlazorServer.BridgePatternExample.Bridges;
using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories;
using BlazorServer.BridgePatternExample.Repositories.Orders;
using BlazorServer.BridgePatternExample.Services.Cards;
using BlazorServer.BridgePatternExample.Services.Conditions;

namespace BlazorServer.BridgePatternExample.Services.Orders
{
    public class OrderService : BaseService<Order, IOrderRepository>, IOrderService
    {
        IConditionService ConditionService;
        ICardService CardService;
        public OrderService(IBaseRepository<Order> repo, IConditionService conditionService, ICardService cardService) : base(repo)
        {
            ConditionService = conditionService;
            CardService = cardService;
        }

        public new Order Add(Order order)
        {
            order.Condition = ConditionService.GetById((int)order.ConditionId!) ?? throw new Exception("Condition was not found!");
            order.Card = CardService.GetById((int)order.CardId!) ?? throw new Exception("Card was not found!");

            order.TotalCost = new MtgCardCostCalculator(order, new ModifierDecider(order).Decider()).CalculatePrice();

            return Repo.Add(order);
        }
    }
}
