using Microsoft.EntityFrameworkCore.Migrations;

namespace ThAmCo.Events.Migrations
{
    public partial class seedingDataCustomer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    ContactNumber = table.Column<long>(nullable: false),
                    EmailId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "ContactNumber", "EmailId", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, 7726354812L, "enim.non.nisi@google.couk", "Ora", "Wagner" },
                    { 2, 0L, "aliquam.nisl.nulla@outlook.edu", "Russell", "Leon" },
                    { 3, 7582648124L, "ultrices.a@yahoo.ca", "Otto", "Spencer" },
                    { 4, 0L, "morbi.tristique@protonmail.couk", "Wanda", "Hebert" },
                    { 5, 7845298243L, "ut.nec.urna@hotmail.org", "Dante", "Luna" },
                    { 6, 0L, "tristique@outlook.edu", "Wing", "Fry" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
