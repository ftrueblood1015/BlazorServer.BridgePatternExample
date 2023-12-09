using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services.Orders;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorServer.BridgePatternExample.Pages.Orders
{
    public partial class AddOrder
    {
        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        [Inject]
        private IOrderService? OrderService { get; set; }

        private Order? NewOrder { get; set; }

        bool success;

        string[] errors = { };

        MudForm? Form;

        protected override async Task OnInitializedAsync()
        {
            NewOrder = new Order();
        }

        private void CancelClick()
        {
            if (NavigationManager != null)
            {
                NavigationManager.NavigateTo("/orders");
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
