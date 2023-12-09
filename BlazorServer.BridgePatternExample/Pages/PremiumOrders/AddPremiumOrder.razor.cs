using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services.Orders;
using BlazorServer.BridgePatternExample.Services.PremiumOrders;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorServer.BridgePatternExample.Pages.PremiumOrders
{
    public partial class AddPremiumOrder
    {
        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        [Inject]
        private IPremiumOrderService? OrderService { get; set; }

        private PremiumOrder? NewOrder { get; set; }

        bool success;

        string[] errors = { };

        MudForm? Form;

        protected override async Task OnInitializedAsync()
        {
            NewOrder = new PremiumOrder();
        }

        private void CancelClick()
        {
            if (NavigationManager != null)
            {
                NavigationManager.NavigateTo("/premiumorders");
            }
        }

        private async void Save()
        {
            success = false;
            await Form!.Validate();

            if (OrderService == null)
            {
                throw new Exception(nameof(OrderService));
            }

            if (Form.IsValid)
            {
                try
                {
                    NewOrder = OrderService.Add(NewOrder!);
                    success = true;
                    StateHasChanged();
                }
                catch
                {
                    success = false;
                }
            }
        }

        public async Task CardChange(int? Id)
        {
            NewOrder!.CardId = Id;
        }

        public async Task ConditionChange(int? Id)
        {
            NewOrder!.ConditionId = Id;
        }
    }
}
