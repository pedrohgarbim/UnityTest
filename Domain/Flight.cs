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

        public void CancelBooking(string passengerEmail, int numberOfSeats)
        {
            RemainingNumberOfSeats += numberOfSeats;

        }
    }
}