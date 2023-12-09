using BlazorServer.BridgePatternExample.Domain.Models;

namespace BlazorServer.BridgePatternExample.Repositories.Orders
{
    public interface IOrderRepository : IBaseRepository<Order>
    {
    }
}
