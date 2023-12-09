using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services.Cards;
using Microsoft.AspNetCore.Components;
using MudBlazor;

namespace BlazorServer.BridgePatternExample.Pages.Cards
{
    public partial class AddCard
    {
        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        [Inject]
        private ICardService? CardService { get; set; }

        private Card? NewCard { get; set; }

        bool success;

        string[] errors = { };

        MudForm? Form;

        protected override async Task OnInitializedAsync()
        {
            NewCard = new Card();
        }

        private void CancelClick()
        {
            if (NavigationManager != null)
            {
                NavigationManager.NavigateTo("/cards");
            }
        }

        private async void Save()
        {
            success = false;
            await Form!.Validate();

            if (CardService == null)
            {
                throw new ArgumentNullException(nameof(CardService));
            }

            if (Form.IsValid)
            {
                try
                {
                    NewCard = CardService.Add(NewCard!);
                    success = true;
                    StateHasChanged();
                }
                catch
                {
                    success = false;
                }
            }
        }

        public async Task RarityChange(int? Id)
        {
            NewCard!.CardRarityId = Id;
        }

        public async Task TypeChange(int? Id)
        {
            NewCard!.CardTypeId = Id;
        }

        public async Task IdentityChange(int? Id)
        {
            NewCard!.ColorIdentityId = Id;
        }
    }
}
