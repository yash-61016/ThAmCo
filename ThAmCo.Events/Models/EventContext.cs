using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThAmCo.Events.Models;
using ThAmCo.Events.DTOs;

namespace ThAmCo.Events.Models
{
    public class EventContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Staff> Staff { get; set; }

        public DbSet<Event> Events { get; set; }
        
        public EventContext(DbContextOptions<EventContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Customer>().HasData(
                new Customer
                {
                    CustomerId = 1,
                    FirstName = "Ora",
                    LastName = "Wagner",
                    ContactNumber = "07726354812",
                    EmailId = "enim.non.nisi@google.couk"
                },
                new Customer
                {
                    CustomerId = 2,
                    FirstName = "Russell",
                    LastName = "Leon",
                    EmailId = "aliquam.nisl.nulla@outlook.edu"
                },
                new Customer
                {
                    CustomerId = 3,
                    FirstName = "Otto",
                    LastName = "Spencer",
                    ContactNumber = "07582648124",
                    EmailId = "ultrices.a@yahoo.ca"
                },
                new Customer
                {
                    CustomerId = 4,
                    FirstName = "Wanda",
                    LastName = "Hebert",
                    EmailId = "morbi.tristique@protonmail.couk"
                },
                new Customer
                {
                    CustomerId = 5,
                    FirstName = "Dante",
                    LastName = "Luna",
                    ContactNumber = "07845298243",
                    EmailId = "ut.nec.urna@hotmail.org"
                },
                new Customer
                {
                    CustomerId = 6,
                    FirstName = "Wing",
                    LastName = "Fry",
                    EmailId = "tristique@outlook.edu"
                }
                );
            builder.Entity<Staff>().HasData(
                new Staff { StaffId = 1, StaffFirstName = "Chloye", StaffLastName = "Parkinson", StaffType = "Waiter" },
                new Staff { StaffId = 2, StaffFirstName = "Idris", StaffLastName = "Ciftci", StaffType = "Bar tender" },
                new Staff { StaffId = 3, StaffFirstName = "Stanley", StaffType = "DJ" },
                new Staff { StaffId = 4, StaffFirstName = "Bradley", StaffType = "Photographer" },
                new Staff { StaffId = 5, StaffFirstName = "Candice", StaffLastName = "Neistat", StaffType = "Wedding planner" },
                new Staff { StaffId = 6, StaffFirstName = "Dhruv", StaffLastName = "Rathi", StaffType = "Waiter" },
                new Staff { StaffId = 7, StaffFirstName = "Casey", StaffLastName = "Neistat", StaffType = "Host" }
                );
            builder.Entity<Event>().HasData(
                new Event { EventId = 1, EventDateTime = new DateTime(2002,11,2, 12 , 30, 00), EventTitle = "Harode's 11th Birthday", EventTypeId = "PTY"},
                new Event { EventId = 2, EventDateTime = new DateTime(2021, 10, 3, 10, 00, 00), EventTitle = "Online Covid-19 vaccination Awareness", EventTypeId = "MET"},
                new Event { EventId = 3, EventDateTime = new DateTime(2019, 04, 19, 8, 30, 00), EventTitle = "Tanmay Weds Tanvi", EventTypeId = "WED"}
                );
        }

        public DbSet<ThAmCo.Events.DTOs.EventTypeDTO> EventTypeDTO { get; set; }


        }
    }
