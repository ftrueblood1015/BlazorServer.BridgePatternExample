using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.BridgePatternExample.Repositories.PremiumOrders
{
    public class PremiumOrderRepository : BaseRepository<PremiumOrder, BridgePatternContext>, IPremiumOrderRepository
    {
        public PremiumOrderRepository(BridgePatternContext context) : base(context)
        {
        }

        public new IEnumerable<Order> GetAll()
        {
            return Context.Set<Order>().Include(x => x.Card).Include(y => y.Condition);
        }
    }
}
