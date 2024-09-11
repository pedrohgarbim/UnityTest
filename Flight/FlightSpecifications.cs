using Xunit;
using Domain.Tests;
using FluentAssertions;
using Domain;

namespace FlightTest
{
    public class FlightSpecifications
    {
        [Theory]
        [InlineData(3,1,2)]
        [InlineData(6, 3, 3)]
        [InlineData(10, 6, 4)]
        public void Booking_reduces_the_number_of_seats(int seatCapacity, int numberOfSeats, int remaningNumberOfSeats)
        {
            var flight = new Flight(seatCapacity: seatCapacity);

            flight.Book("realomniman@superdefender.com", numberOfSeats);

            flight.RemainingNumberOfSeats.Should().Be(remaningNumberOfSeats);   
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

        [Fact]
        public void Books_flights_successfully()
        {
            var flight = new Flight(seatCapacity: 3);
            var error = flight.Book("realomniman@superdefender.com", 1);
            error.Should().BeNull();
        }

        [Fact]
        public void Remembers_bookings()
        {
            var flight = new Flight(seatCapacity: 150);
            flight.Book(passengerEmail: "A@bb.com", numberOfSeats: 4);
        }
    }
}
