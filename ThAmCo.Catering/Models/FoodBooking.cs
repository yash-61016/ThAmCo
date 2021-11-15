using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Catering.Models
{
    public class FoodBooking
    {
        public FoodBooking()
        {

        }
        public FoodBooking(int numberOfGuests) : this()
        {
            NumberOfGuests = numberOfGuests;
        }
        public int FoodBookingId { get; set; }
        public int ClientReferenceId { get; set; }
        public int NumberOfGuests { get; set; }
        public int MenuId { get; set; }
        public Menu menu { get; set; }
    }
}
