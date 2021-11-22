using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Events.Models
{
    public class GuestBooking
    {
        public int GuestBookingId { get; set; }

        public int EventId { get; set; }

        public int CustomerId { get; set; }

        public string Attendence { get; set; }

        public Event Evts { get; set; }
        public Customer Cutcs { get; set; }
    }
}
