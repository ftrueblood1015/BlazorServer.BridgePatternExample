using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories.Orders;

namespace BlazorServer.BridgePatternExample.Services.Orders
{
    public interface IOrderService : IBaseService<Order>
    { 

    }
}
