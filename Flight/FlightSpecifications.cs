using Xunit;
using Domain.Tests;
using FluentAssertions;
using Domain;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Fact]
        public void Booking_reduces_the_number_of_seats()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("realomniman@superdefender.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);   
        }

        [Fact]
        public void Avoids_overbooking()
        {
            //Given
            var flight = new Flight(seatCapacity: 3);
            //When
            var error = flight.Book("realomniman@superdefender.com", 4);
            //Then
            error.Should().BeOfType<OverbookingError>();
        }
    }
}
