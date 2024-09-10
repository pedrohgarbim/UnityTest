using Xunit;
using Domain.Tests;
using FluentAssertions;
using Domain;

namespace FlightTest
{
    public class FlightTest
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("realomniman@superdefender.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);   
        }
    }
}
