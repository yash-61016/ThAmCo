using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Migrations
{
    public partial class SeedingEventData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    EventId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EventDateTime = table.Column<DateTime>(nullable: false),
                    EventTitle = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.EventId);
                });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventDateTime", "EventTitle" },
                values: new object[] { 1, new DateTime(2002, 11, 2, 12, 30, 0, 0, DateTimeKind.Unspecified), "Harode's 11th Birthday" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventDateTime", "EventTitle" },
                values: new object[] { 2, new DateTime(2021, 10, 3, 10, 0, 0, 0, DateTimeKind.Unspecified), "Online Covid-19 vaccination Awareness" });

            migrationBuilder.InsertData(
                table: "Events",
                columns: new[] { "EventId", "EventDateTime", "EventTitle" },
                values: new object[] { 3, new DateTime(2019, 4, 19, 8, 30, 0, 0, DateTimeKind.Unspecified), "Tanmay Weds Tanvi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}
