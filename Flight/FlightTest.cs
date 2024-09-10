using Xunit;
using Domain.Tests;
using FluentAssertions;

namespace FlightTest
{
    public class FlightTest
    {
        [Fact]
        public void Test1()
        {
            var flight = new Flight(seatCapacity: 3);

            flight.Book("realomniman@superdefender.com", 1);

            flight.RemainingNumberOfSeats.Should().Be(2);   
        }
    }
}
