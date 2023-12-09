using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services.Cards;
using BlazorServer.BridgePatternExample.Services.Orders;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.BridgePatternExample.Pages.Orders
{
    public partial class Orders
    {

        [Inject]
        private NavigationManager? NavigationManager {  get; set; }
        [Inject]
        private IOrderService? OrderService { get; set; }

        private List<Order>? OrderList {  get; set; }

        private string? SearchString { get; set; }

        private string Title = "Orders";

        protected override async Task OnInitializedAsync()
        {
            GetData();
        }

        public void GetData()
        {
            if (OrderService == null)
            {
                throw new Exception($"{nameof(OrderService)}  is null!");
            }
            var Response = OrderService.GetAll();
            OrderList = Response != null ? Response.ToList() : new List<Order>();
            StateHasChanged();
        }

        private Func<Order, bool> QuickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(SearchString))
                return true;

            if (x.Card!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Condition!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.TotalCost}".Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };

        public void AddOrder() 
        { 
            if (NavigationManager == null)
            {
                throw new Exception(nameof(NavigationManager));
            }

            NavigationManager.NavigateTo("/addorder");
        }
    }
}
