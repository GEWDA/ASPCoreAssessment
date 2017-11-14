using ASPCoreAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCoreAssessment.Services
{
    public class FakeHotelService : IHotelService
    {
        public Task<IEnumerable<HotelRoom>> GetRoomsAsync()
        {
            IEnumerable<HotelRoom> rooms = new[]
            {
                new HotelRoom
                {
                    NumberDoubleBeds=1,NumberExtraBeds=1,NumberSingleBeds=2,RoomNumber=1,PriceSingle=3,PriceDouble=4,PricePerExtra=5
                },
                new HotelRoom
                {
                    NumberDoubleBeds=3,NumberExtraBeds=3,NumberSingleBeds=5,RoomNumber=3,PriceSingle=7,PriceDouble=6,PricePerExtra=5
                }
            };


            return Task.FromResult(rooms);
        }


        public Task<IEnumerable<HotelBooking>> GetBookingsAsync()
        {
            IEnumerable<HotelBooking> bookings = new[]
            {
                new HotelBooking
                {
                    BookingFrom=DateTimeOffset.Now.AddDays(2),BookingTo=DateTimeOffset.Now.AddDays(9),RoomCost=21,Room=new HotelRoom{NumberSingleBeds=99}
                },
                new HotelBooking
                {
                    BookingFrom=DateTimeOffset.Now.AddDays(4),BookingTo=DateTimeOffset.Now.AddDays(14),RoomCost=21,Room=new HotelRoom{NumberDoubleBeds=99}
                }
            };


            return Task.FromResult(bookings);
        }
        public Task<IEnumerable<HotelGuest>> GetGuestsAsync()
        {
            IEnumerable<HotelGuest> guests = new[]
            {
                new HotelGuest
                {
                    Address="123 Fake St", Booking=new HotelBooking{Room=new HotelRoom{NumberExtraBeds=99}},BookingDate=DateTimeOffset.Now.AddDays(-13),CheckIn=DateTimeOffset.Now.AddDays(1),CheckOut=DateTimeOffset.Now.AddDays(7),FirstName="Joe",LastName="Blogs",NumberOfGuests=1
                },
                new HotelGuest
                {
                    Address="987 Fake St", Booking=new HotelBooking{Room=new HotelRoom{RoomNumber=99}},BookingDate=DateTimeOffset.Now.AddDays(-11),CheckIn=DateTimeOffset.Now.AddDays(3),CheckOut=DateTimeOffset.Now.AddDays(6),FirstName="John",LastName="Smith",NumberOfGuests=2
                }
            };


            return Task.FromResult(guests);
        }
        public Task<IEnumerable<HotelBill>> GetBillingAsync()
        {
            IEnumerable<HotelBill> billing = new[]
            {
                new HotelBill
                {
                    Guest=new HotelGuest{BookingDate=DateTimeOffset.Now,Booking=new HotelBooking{RoomCost=99,Room=new HotelRoom{PricePerExtra=99}},FirstName="Guest" },WiFiCharge=99,BarCharge=0,RoomCharge=45,TelephoneCharge=0
                },
                new HotelBill
                {
                    Guest=new HotelGuest{BookingDate=DateTimeOffset.Now,Booking=new HotelBooking{RoomCost=99,Room=new HotelRoom{PricePerExtra=99}},FirstName="Alcoholic" },WiFiCharge=0,BarCharge=99,RoomCharge=45,TelephoneCharge=0
                }
            };


            return Task.FromResult(billing);
        }
    }
}
