// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Events.Models;

namespace ThAmCo.Events.Migrations
{
    [DbContext(typeof(EventContext))]
    [Migration("20211116001933_seedingDataCustomer")]
    partial class seedingDataCustomer
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.21")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ThAmCo.Events.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ContactNumber")
                        .HasColumnType("bigint");

                    b.Property<string>("EmailId")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            ContactNumber = 7726354812L,
                            EmailId = "enim.non.nisi@google.couk",
                            FirstName = "Ora",
                            LastName = "Wagner"
                        },
                        new
                        {
                            CustomerId = 2,
                            ContactNumber = 0L,
                            EmailId = "aliquam.nisl.nulla@outlook.edu",
                            FirstName = "Russell",
                            LastName = "Leon"
                        },
                        new
                        {
                            CustomerId = 3,
                            ContactNumber = 7582648124L,
                            EmailId = "ultrices.a@yahoo.ca",
                            FirstName = "Otto",
                            LastName = "Spencer"
                        },
                        new
                        {
                            CustomerId = 4,
                            ContactNumber = 0L,
                            EmailId = "morbi.tristique@protonmail.couk",
                            FirstName = "Wanda",
                            LastName = "Hebert"
                        },
                        new
                        {
                            CustomerId = 5,
                            ContactNumber = 7845298243L,
                            EmailId = "ut.nec.urna@hotmail.org",
                            FirstName = "Dante",
                            LastName = "Luna"
                        },
                        new
                        {
                            CustomerId = 6,
                            ContactNumber = 0L,
                            EmailId = "tristique@outlook.edu",
                            FirstName = "Wing",
                            LastName = "Fry"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
