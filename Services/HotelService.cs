using ASPCoreAssessment.Models;
using ASPCoreAssessment.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreAssessment.Services
{
    public class HotelService : IHotelService
    {
        private readonly ApplicationDbContext _context;

        public HotelService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<HotelRoom>> GetRoomsAsync()
        {
            var rooms = await _context.Rooms.ToArrayAsync();
            return rooms;
        }
        public async Task<IEnumerable<HotelBooking>> GetBookingsAsync()
        {
            var bookings = await _context.Booking
                .Where(x => (x.BookingTo.Subtract(DateTimeOffset.Now)).TotalDays>0)//where the BookingTo date has not been passed
                .ToArrayAsync();
            return bookings;
        }
        public async Task<IEnumerable<HotelGuest>> GetGuestsAsync()
        {
            var guests = await _context.Guests.ToArrayAsync();
            return guests;
        }
        public async Task<IEnumerable<HotelBill>> GetBillingAsync()
        {
            var billing = await _context.Billing.ToArrayAsync();
            return billing;
        }
    }
}
