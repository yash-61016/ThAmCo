using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Catering.Migrations
{
    public partial class initialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    FoodItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(nullable: false),
                    UnitPrice = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.FoodItemID);
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "FoodItemID", "Description", "UnitPrice" },
                values: new object[,]
                {
                    { 1, "Shepherd’s Pie", 3.5f },
                    { 2, "Beef Wellington", 5f },
                    { 3, "Fish and Chips", 3.75f },
                    { 4, "Chicken Tikka Masala", 2.5f },
                    { 5, "Steak and Kidney pie", 3.75f },
                    { 6, "Eton Mess", 5.5f },
                    { 7, "Cornish pasty", 3.25f },
                    { 8, "Bangers and Mash", 2.95f },
                    { 9, "Toad in the hole", 2.6f },
                    { 10, "Rib Eye Steak", 4.9f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodItems");
        }
    }
}
