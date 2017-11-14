using ASPCoreAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAssessment.Services
{
    public interface IHotelService
    {
        Task<IEnumerable<HotelRoom>> GetRoomsAsync();
        Task<IEnumerable<HotelBooking>> GetBookingsAsync();
        Task<IEnumerable<HotelGuest>> GetGuestsAsync();
        Task<IEnumerable<HotelBill>> GetBillingAsync();
    }
}
