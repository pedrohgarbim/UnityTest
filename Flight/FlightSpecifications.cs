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
            flight.BookingList.Should().ContainEquivalentOf(new Booking("A@bb.com", 4));
        }

        [Theory]
        [InlineData(3,1,1,3)]
        [InlineData(4, 2, 2, 4)]
        [InlineData(7, 5, 4, 6)]
        public void Canceling_bookings_frees_up_the_seats(
            int initialCapacity,
            int numberOfSeatsToBooks,
            int numberOfSeatsToCancel,
            int remainingNumberOfSeats
            )
        {
            //given
            var flight = new Flight(initialCapacity);           
            flight.Book(passengerEmail: "A@bb.com", numberOfSeats: numberOfSeatsToBooks);
            //when
            flight.CancelBooking(passengerEmail: "A@bb.com", numberOfSeats: numberOfSeatsToCancel);
            //then
            flight.RemainingNumberOfSeats.Should().Be(remainingNumberOfSeats);
        }
    }
}
