using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorServer.BridgePatternExample.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CardRarities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Common", "Common" });

            migrationBuilder.InsertData(
                table: "CardRarities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Uncommon", "Uncommon" });

            migrationBuilder.InsertData(
                table: "CardRarities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Rare", "Rare" });

            migrationBuilder.InsertData(
                table: "CardRarities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "Legendary", "Legendary" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Creature", "Creature" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Land", "Land" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Scorcery", "Scorcery" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "Instant", "Instant" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, "Artifact", "Artifact" });

            migrationBuilder.InsertData(
                table: "CardTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 6, "Enchantment", "Enchantment" });

            migrationBuilder.InsertData(
                table: "ColorIdentities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Blue", "U" });

            migrationBuilder.InsertData(
                table: "ColorIdentities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Red", "R" });

            migrationBuilder.InsertData(
                table: "ColorIdentities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "White", "W" });

            migrationBuilder.InsertData(
                table: "ColorIdentities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "Green", "G" });

            migrationBuilder.InsertData(
                table: "ColorIdentities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, "Black", "B" });

            migrationBuilder.InsertData(
                table: "ColorIdentities",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 6, "Colorless", "L" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Damaged", "Damaged" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Heavily Played", "Heavily Played" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Moderately Played", "Moderately Played" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "Lightly Played", "Lightly Played" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, "Near Mint", "Near Mint" });

            migrationBuilder.InsertData(
                table: "Conditions",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 6, "Mint", "Mint" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "BaseCost", "CardRarityId", "CardTypeId", "ColorIdentityId", "ConvertedManaCost", "Description", "Name", "Set" },
                values: new object[] { 1, 1000, 3, 2, 4, 0, "Gaea's Cradle", "Gaea's Cradle", "Urza's Saga" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "BaseCost", "CardRarityId", "CardTypeId", "ColorIdentityId", "ConvertedManaCost", "Description", "Name", "Set" },
                values: new object[] { 2, 500, 3, 1, 1, 5, "Sliver Queen", "Sliver Queen", "Stronghold" });

            migrationBuilder.InsertData(
                table: "Cards",
                columns: new[] { "Id", "BaseCost", "CardRarityId", "CardTypeId", "ColorIdentityId", "ConvertedManaCost", "Description", "Name", "Set" },
                values: new object[] { 3, 150000, 3, 5, 6, 0, "Black Lotus", "Black Lotus", "Alpha" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CardId", "Comments", "ConditionId", "Description", "Name", "TotalCost" },
                values: new object[] { 1, 1, "None", 6, "Gaea's Cradel - Mint", "Mint Gaea's Cradel", 3000 });

            migrationBuilder.InsertData(
                table: "PremiumOrders",
                columns: new[] { "Id", "CardId", "Comments", "ConditionId", "Description", "Name", "PricePremium", "Reason", "TotalCost" },
                values: new object[] { 1, 1, "None", 6, "Gaea's Cradel - Mint", "Mint Gaea's Cradel", 300, "Promo Card", 3000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ColorIdentities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ColorIdentities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ColorIdentities",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PremiumOrders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cards",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ColorIdentities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ColorIdentities",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Conditions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CardRarities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CardTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ColorIdentities",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
