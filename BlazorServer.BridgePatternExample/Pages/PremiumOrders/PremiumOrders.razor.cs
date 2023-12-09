using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services.Orders;
using BlazorServer.BridgePatternExample.Services.PremiumOrders;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.BridgePatternExample.Pages.PremiumOrders
{
    public partial class PremiumOrders
    {
        [Inject]
        private NavigationManager? NavigationManager { get; set; }
        [Inject]
        private IPremiumOrderService? PremiumOrderService { get; set; }

        private List<PremiumOrder>? OrderList { get; set; }

        private string? SearchString { get; set; }

        private string Title = "Premium Orders";

        protected override async Task OnInitializedAsync()
        {
            GetData();
        }

        public void GetData()
        {
            if (PremiumOrderService == null)
            {
                throw new Exception($"{nameof(PremiumOrderService)}  is null!");
            }
            var Response = PremiumOrderService.GetAll();
            OrderList = Response != null ? Response.ToList() : new List<PremiumOrder>();
            StateHasChanged();
        }

        private Func<PremiumOrder, bool> QuickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(SearchString))
                return true;

            if (x.Card!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Condition!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Reason!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
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

            NavigationManager.NavigateTo("/addpremiumorder");
        }
    }
}
