using BlazorServer.BridgePatternExample.Domain.Models;
using BlazorServer.BridgePatternExample.Repositories.Cards;
using BlazorServer.BridgePatternExample.Repositories.Conditions;
using BlazorServer.BridgePatternExample.Repositories.Orders;
using BlazorServer.BridgePatternExample.Services.Cards;
using BlazorServer.BridgePatternExample.Services.Conditions;
using BlazorServer.BridgePatternExample.Services.Orders;
using BlazorServer.BridgePatternExample.UnitTests.MockBases;
using Shouldly;

namespace BlazorServer.BridgePatternExample.UnitTests.ServiceTests
{
    public class OrderServiceTests
    {
        private readonly OrderService OrderService;
        private readonly CardService CardService;
        private readonly ConditionService ConditionService;

        public OrderServiceTests()
        {
            var OrderRepo = MockRepoBase.MockRepo<IOrderRepository, Order>(new List<Order>()
                {
                    new Order { Id = 1, CardId = 1, ConditionId = 6, Comments = "None", Description = "Gaea's Cradel - Mint", Name = "Mint Gaea's Cradel", TotalCost = 3000 }
                }    
            );

            var cardRepo = MockRepoBase.MockRepo<ICardRepository, Card>( new List<Card>()
                {
                    new Card { Id = 1, BaseCost = 1000, CardRarityId = 3, CardTypeId = 2, ColorIdentityId = 4, ConvertedManaCost = 0, Description = "Gaea's Cradle", Name = "Gaea's Cradle", Set = "Urza's Saga" },
                    new Card { Id = 2, BaseCost = 500, CardRarityId = 3, CardTypeId = 1, ColorIdentityId = 1, ConvertedManaCost = 5, Description = "Sliver Queen", Name = "Sliver Queen", Set = "Stronghold" },
                    new Card { Id = 3, BaseCost = 150000, CardRarityId = 3, CardTypeId = 5, ColorIdentityId = 6, ConvertedManaCost = 0, Description = "Black Lotus", Name = "Black Lotus", Set = "Alpha" }
                }
            );

            var ConditionRepo = MockRepoBase.MockRepo<IConditionRepository, Condition>( new List<Condition>()
                {
                    new Condition { Id = 1, Description = "Damaged", Name = "Damaged"},
                    new Condition { Id = 2, Description = "Heavily Played", Name = "Heavily Played" },
                    new Condition { Id = 3, Description = "Moderately Played", Name = "Moderately Played" },
                    new Condition { Id = 4, Description = "Lightly Played", Name = "Lightly Played" },
                    new Condition { Id = 5, Description = "Near Mint", Name = "Near Mint" },
                    new Condition { Id = 6, Description = "Mint", Name = "Mint" }
                }    
            );

            CardService = new CardService(cardRepo.Object);
            ConditionService = new ConditionService(ConditionRepo.Object);
            OrderService = new OrderService(OrderRepo.Object, ConditionService, CardService);
        }

        [Test]
        public void DamagedCard_Order_HasCorrectPrice()
        {
            // Arrange
            var Order = new Order { Name = "Damaged Test", CardId = 1, ConditionId = 1, Comments = "Comments" };

            // Act
            var result = OrderService.Add(Order);

            // Assert
            result.TotalCost.ShouldBe((int)((double)Order.Card!.BaseCost! * 0.5));
        }

        [Test]
        public void HeavilyPlayedCard_Order_HasCorrectPrice()
        {
            // Arrange
            var Order = new Order { Name = "Heavily Played Test", CardId = 1, ConditionId = 2, Comments = "Comments" };

            // Act
            var result = OrderService.Add(Order);

            // Assert
            result.TotalCost.ShouldBe((int)((double)Order.Card!.BaseCost! * 0.75));
        }

        [Test]
        public void ModeratelyPlayedCard_Order_HasCorrectPrice()
        {
            // Arrange
            var Order = new Order { Name = "Moderately Played Test", CardId = 1, ConditionId = 3, Comments = "Comments" };

            // Act
            var result = OrderService.Add(Order);

            // Assert
            result.TotalCost.ShouldBe((int)((double)Order.Card!.BaseCost! * 0.9));
        }

        [Test]
        public void LightlyPlayedCard_Order_HasCorrectPrice()
        {
            // Arrange
            var Order = new Order { Name = "Lightly Played Test", CardId = 1, ConditionId = 4, Comments = "Comments" };

            // Act
            var result = OrderService.Add(Order);

            // Assert
            result.TotalCost.ShouldBe((int)((double)Order.Card!.BaseCost! * 1));
        }

        [Test]
        public void NearMintCard_Order_HasCorrectPrice()
        {
            // Arrange
            var Order = new Order { Name = "Near Mint Test", CardId = 1, ConditionId = 5, Comments = "Comments" };

            // Act
            var result = OrderService.Add(Order);

            // Assert
            result.TotalCost.ShouldBe((int)((double)Order.Card!.BaseCost! * 2));
        }

        [Test]
        public void MintCard_Order_HasCorrectPrice()
        {
            // Arrange
            var Order = new Order { Name = "Mint Test", CardId = 1, ConditionId = 6, Comments = "Comments" };

            // Act
            var result = OrderService.Add(Order);

            // Assert
            result.TotalCost.ShouldBe((int)((double)Order.Card!.BaseCost! * 3));
        }
    }
}
