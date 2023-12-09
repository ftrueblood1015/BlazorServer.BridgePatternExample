using BlazorServer.BridgePatternExample.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServer.BridgePatternExample.Infrastructure
{
    public class BridgePatternContext : DbContext
    {
        public BridgePatternContext(DbContextOptions<BridgePatternContext> options) : base(options) { }

        DbSet<Order> Orders => Set<Order>();
        DbSet<Condition> Conditions => Set<Condition>();
        DbSet<ColorIdentity> ColorIdentities => Set<ColorIdentity>();
        DbSet<CardType> CardTypes => Set<CardType>();
        DbSet<CardRarity> CardRarities => Set<CardRarity>();
        DbSet<Card> Cards => Set<Card>();
        DbSet<PremiumOrder> PremiumOrders => Set<PremiumOrder>();
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Condition>().HasData(
                new Condition { Id = 1, Description = "Damaged", Name = "Damaged"},
                new Condition { Id = 2, Description = "Heavily Played", Name = "Heavily Played" },
                new Condition { Id = 3, Description = "Moderately Played", Name = "Moderately Played" },
                new Condition { Id = 4, Description = "Lightly Played", Name = "Lightly Played" },
                new Condition { Id = 5, Description = "Near Mint", Name = "Near Mint" },
                new Condition { Id = 6, Description = "Mint", Name = "Mint" }
            );

            modelBuilder.Entity<ColorIdentity>().HasData(
                new ColorIdentity { Id = 1, Description = "Blue", Name = "U" },
                new ColorIdentity { Id = 2, Description = "Red", Name = "R" },
                new ColorIdentity { Id = 3, Description = "White", Name = "W" },
                new ColorIdentity { Id = 4, Description = "Green", Name = "G" },
                new ColorIdentity { Id = 5, Description = "Black", Name = "B" },
                new ColorIdentity { Id = 6, Description = "Colorless", Name = "L" }
            );

            modelBuilder.Entity<CardRarity>().HasData(
                new CardRarity { Id = 1, Description = "Common", Name = "Common" },
                new CardRarity { Id = 2, Description = "Uncommon", Name = "Uncommon" },
                new CardRarity { Id = 3, Description = "Rare", Name = "Rare" },
                new CardRarity { Id = 4, Description = "Legendary", Name = "Legendary" }
            );

            modelBuilder.Entity<CardType>().HasData(
                new CardType { Id = 1, Description = "Creature", Name = "Creature" },
                new CardType { Id = 2, Description = "Land", Name = "Land" },
                new CardType { Id = 3, Description = "Scorcery", Name = "Scorcery" },
                new CardType { Id = 4, Description = "Instant", Name = "Instant" },
                new CardType { Id = 5, Description = "Artifact", Name = "Artifact" },
                new CardType { Id = 6, Description = "Enchantment", Name = "Enchantment" }
            );

            modelBuilder.Entity<Card>().HasData(
                new Card { Id = 1, BaseCost = 1000, CardRarityId = 3, CardTypeId = 2, ColorIdentityId = 4, ConvertedManaCost = 0, Description = "Gaea's Cradle", Name = "Gaea's Cradle", Set = "Urza's Saga" },
                new Card { Id = 2, BaseCost = 500, CardRarityId = 3, CardTypeId = 1, ColorIdentityId = 1, ConvertedManaCost = 5, Description = "Sliver Queen", Name = "Sliver Queen", Set = "Stronghold" },
                new Card { Id = 3, BaseCost = 150000, CardRarityId = 3, CardTypeId = 5, ColorIdentityId = 6, ConvertedManaCost = 0, Description = "Black Lotus", Name = "Black Lotus", Set = "Alpha" }
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, CardId = 1, ConditionId = 6, Comments = "None", Description = "Gaea's Cradel - Mint", Name = "Mint Gaea's Cradel", TotalCost = 3000 }
            );
            modelBuilder.Entity<PremiumOrder>().HasData(
                new PremiumOrder { Id = 1, CardId = 1, ConditionId = 6, Comments = "None", Description = "Gaea's Cradel - Mint", Name = "Mint Gaea's Cradel", TotalCost = 3000, Reason = "Promo Card", PricePremium = 300 }
            );
        }
    }
}
