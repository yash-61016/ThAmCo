using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Migrations
{
    public partial class createdStaff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    StaffId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StaffFirstName = table.Column<string>(nullable: false),
                    StaffLastName = table.Column<string>(nullable: true),
                    StaffType = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.StaffId);
                });

            migrationBuilder.InsertData(
                table: "Staff",
                columns: new[] { "StaffId", "StaffFirstName", "StaffLastName", "StaffType" },
                values: new object[,]
                {
                    { 1, "Chloye", "Parkinson", "Waiter" },
                    { 2, "Idris", "Ciftci", "Bar tender" },
                    { 3, "Stanley", null, "DJ" },
                    { 4, "Bradley", null, "Photographer" },
                    { 5, "Candice", "Neistat", "Wedding planner" },
                    { 6, "Dhruv", "Rathi", "Waiter" },
                    { 7, "Casey", "Neistat", "Host" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Staff");
        }
    }
}
