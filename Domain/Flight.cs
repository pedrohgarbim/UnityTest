using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Flight
    {
        List<Booking> bookingsList = new();
        public IEnumerable<Booking> BookingList => bookingsList;
       
        public int RemainingNumberOfSeats { get; set; }

        public Flight(int seatCapacity)
        {
            RemainingNumberOfSeats = seatCapacity;
        }

        public object? Book(string passengerEmail, int numberOfSeats)
        {

            if (numberOfSeats > this.RemainingNumberOfSeats)
                return new OverbookingError();
            
            RemainingNumberOfSeats -= numberOfSeats;

            bookingsList.Add(new Booking(passengerEmail, numberOfSeats));
            return null;
        }

        public object? CancelBooking(string passengerEmail, int numberOfSeats)
        {

            if (!bookingsList.Any(booking => booking.Email == passengerEmail))
                return new BookingNotFoundError();


            RemainingNumberOfSeats += numberOfSeats;
            return null;

        }
    }
}