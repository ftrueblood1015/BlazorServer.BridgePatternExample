using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Services.Cards;
using Microsoft.AspNetCore.Components;

namespace BlazorServer.BridgePatternExample.Pages.Cards
{
    public partial class Cards
    {
        [Inject]
        private NavigationManager? NavigationManager { get; set; }

        [Inject]
        private ICardService? CardService { get; set; }

        private List<Card>? CardList { get; set; }

        private string? SearchString { get; set; }

        private string Title = "Cards";

        protected override async Task OnInitializedAsync()
        {
            GetData();
        }

        public void GetData()
        {
            if (CardService == null)
            {
                throw new Exception($"{nameof(CardService)}  is null!");
            }
            var Response = CardService.GetAll();
            CardList = Response != null ? Response.ToList() : new List<Card>();
            StateHasChanged();
        }

        private Func<Card, bool> QuickFilter => x =>
        {
            if (string.IsNullOrWhiteSpace(SearchString))
                return true;

            if (x.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.Set!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if ($"{x.BaseCost}".Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.CardRarity!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.CardType!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            if (x.ColorIdentity!.Name!.Contains(SearchString, StringComparison.OrdinalIgnoreCase))
                return true;

            return false;
        };

        public void AddCard()
        {
            if (NavigationManager == null)
            {
                throw new Exception($"{nameof(NavigationManager)}  is null!");
            }
            NavigationManager.NavigateTo("/addcard");
        }
    }
}
