using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Catering.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.MenuId);
                });

            migrationBuilder.CreateTable(
                name: "MenuFoodItems",
                columns: table => new
                {
                    MenuId = table.Column<int>(nullable: false),
                    FoodItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuFoodItems", x => new { x.MenuId, x.FoodItemId });
                    table.ForeignKey(
                        name: "FK_MenuFoodItems_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "FoodItemID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuFoodItems_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "MenuId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 3,
                column: "Description",
                value: "Naan");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 5,
                column: "Description",
                value: "Pizza");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 6,
                column: "Description",
                value: "Ravioli");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 7,
                column: "Description",
                value: "Lasagna");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 8,
                column: "Description",
                value: "Fried Rice");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 9,
                column: "Description",
                value: "Spring Roles");

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "MenuId", "MenuName" },
                values: new object[,]
                {
                    { 1, "British Cuisine" },
                    { 2, "Indian Cuisine" },
                    { 3, "Italian Cuisine" },
                    { 4, "Chinese Cuisine" }
                });

            migrationBuilder.InsertData(
                table: "MenuFoodItems",
                columns: new[] { "MenuId", "FoodItemId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 10 },
                    { 2, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 4, 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_MenuFoodItems_FoodItemId",
                table: "MenuFoodItems",
                column: "FoodItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MenuFoodItems");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 3,
                column: "Description",
                value: "Fish and Chips");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 5,
                column: "Description",
                value: "Steak and Kidney pie");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 6,
                column: "Description",
                value: "Eton Mess");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 7,
                column: "Description",
                value: "Cornish pasty");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 8,
                column: "Description",
                value: "Bangers and Mash");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "FoodItemID",
                keyValue: 9,
                column: "Description",
                value: "Toad in the hole");
        }
    }
}
