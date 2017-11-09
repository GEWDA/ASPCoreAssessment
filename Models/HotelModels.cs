using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreAssessment.Models
{
    /// <summary>
    /// Hotel Room Model
    /// </summary>
    public class HotelRoom
    {
        public Guid Id { get; set; }
        public int RoomNumber { get; set; }
        public int NumberSingleBeds { get; set; }
        public int NumberDoubleBeds { get; set; }
        public int? NumberExtraBeds { get; set; }
        public double PriceSingle { get; set; }
        public double PriceDouble { get; set; }
        public double PricePerExtra { get; set; }
    }

    /// <summary>
    /// Hotel Guest Model
    /// </summary>
    public class HotelGuest
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public int NumberOfGuests { get; set; }
        public int RoomBooked { get; set; }
        public HotelBooking Booking { get; set; }
        public int HotelBookingId { get; set; }
        public DateTimeOffset CheckIn { get; set; }
        public DateTimeOffset CheckOut { get; set; }
        public DateTimeOffset BookingDate { get; set; }
    }

    /// <summary>
    /// Hotel Bill Model
    /// </summary>
    public class HotelBill
    {
        public Guid Id { get; set; }
        public HotelGuest Guest { get; set; }
        public int HotelGuestId { get; set; }
        public double? BarCharge { get; set; }
        public double? WiFiCharge { get; set; }
        public double? TelephoneCharge { get; set; }
        public double RoomCharge { get; set; }
    }

    /// <summary>
    /// Hotel Booking Model
    /// </summary>
    public class HotelBooking
    {
        public Guid Id { get; set; }
        public HotelRoom Room { get; set; }
        public int HotelRoomId { get; set; }
        public DateTimeOffset BookingFrom { get; set; }
        public DateTimeOffset BookingTo { get; set; }
        public double RoomCost { get; set; }
    }
}
