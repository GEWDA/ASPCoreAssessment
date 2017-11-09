using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAssessment.Models
{
    public class HotelViewModelRoom
    {
        public IEnumerable<HotelRoom> Rooms { get; set; }
    }
    public class HotelViewModelBooking
    {
        public IEnumerable<HotelBooking> Bookings { get; set; }
    }
    public class HotelViewModelGuest
    {
        public IEnumerable<HotelGuest> Guests { get; set; }
    }
    public class HotelViewModelBill
    {
        public IEnumerable<HotelBill> Billing { get; set; }
    }
}
