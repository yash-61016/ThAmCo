﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ThAmCo.Events.Models;

namespace ThAmCo.Events.Migrations
{
    [DbContext(typeof(EventContext))]
    partial class EventContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

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
                            ContactNumber = "07726354812",
                            EmailId = "enim.non.nisi@google.couk",
                            FirstName = "Ora",
                            LastName = "Wagner"
                        },
                        new
                        {
                            CustomerId = 2,
                            EmailId = "aliquam.nisl.nulla@outlook.edu",
                            FirstName = "Russell",
                            LastName = "Leon"
                        },
                        new
                        {
                            CustomerId = 3,
                            ContactNumber = "07582648124",
                            EmailId = "ultrices.a@yahoo.ca",
                            FirstName = "Otto",
                            LastName = "Spencer"
                        },
                        new
                        {
                            CustomerId = 4,
                            EmailId = "morbi.tristique@protonmail.couk",
                            FirstName = "Wanda",
                            LastName = "Hebert"
                        },
                        new
                        {
                            CustomerId = 5,
                            ContactNumber = "07845298243",
                            EmailId = "ut.nec.urna@hotmail.org",
                            FirstName = "Dante",
                            LastName = "Luna"
                        },
                        new
                        {
                            CustomerId = 6,
                            EmailId = "tristique@outlook.edu",
                            FirstName = "Wing",
                            LastName = "Fry"
                        });
                });

            modelBuilder.Entity("ThAmCo.Events.Models.Staff", b =>
                {
                    b.Property<int>("StaffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StaffFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StaffId");

                    b.ToTable("Staff");

                    b.HasData(
                        new
                        {
                            StaffId = 1,
                            StaffFirstName = "Chloye",
                            StaffLastName = "Parkinson",
                            StaffType = "Waiter"
                        },
                        new
                        {
                            StaffId = 2,
                            StaffFirstName = "Idris",
                            StaffLastName = "Ciftci",
                            StaffType = "Bar tender"
                        },
                        new
                        {
                            StaffId = 3,
                            StaffFirstName = "Stanley",
                            StaffType = "DJ"
                        },
                        new
                        {
                            StaffId = 4,
                            StaffFirstName = "Bradley",
                            StaffType = "Photographer"
                        },
                        new
                        {
                            StaffId = 5,
                            StaffFirstName = "Candice",
                            StaffLastName = "Neistat",
                            StaffType = "Wedding planner"
                        },
                        new
                        {
                            StaffId = 6,
                            StaffFirstName = "Dhruv",
                            StaffLastName = "Rathi",
                            StaffType = "Waiter"
                        },
                        new
                        {
                            StaffId = 7,
                            StaffFirstName = "Casey",
                            StaffLastName = "Neistat",
                            StaffType = "Host"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
