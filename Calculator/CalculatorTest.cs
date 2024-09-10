using Domain;
using FluentAssertions;
using System;
using Xunit;


namespace CalculatorTest
{
    public class CalculatorTest
    {
        [Fact]
        public void Sum_of_2_and_2_should_be_4()
         => new Calculator()
            .Sum(2, 2)
            .Should().Be(4);

        
    }
}
