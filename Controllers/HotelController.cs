using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASPCoreAssessment.Services;
using ASPCoreAssessment.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreAssessment.Controllers
{
    public class HotelController : Controller
    {
        private readonly IHotelService _hotelService;
        public HotelController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        public async Task<IActionResult> Index()
        {
            var hotelRooms = await _hotelService.GetRoomsAsync();
            var hotelBookings = await _hotelService.GetBookingsAsync();
            var hotelGuests = await _hotelService.GetGuestsAsync();
            var hotelBilling = await _hotelService.GetBillingAsync();

            var model = new HotelViewModel_ALL_()
            {
                Rooms = hotelRooms,
                Bookings = hotelBookings,
                Guests = hotelGuests,
                Billing = hotelBilling
            };
            //Put items into a model

            //Pass view to model and render

            return View(model);
        }
    }
}
