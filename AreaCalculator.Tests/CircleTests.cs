namespace AreaCalculator.Tests;

using FluentAssertions;
using Xunit;

public class CircleTests
{
    public class CalculateAreaTests
    {
        [Fact]
        public void CalculatesCorrectly()
        {
            var circle = Circle.Create(5);

            var actual = circle.CalculateArea();

            actual
                .Should()
                .Be(25 * Math.PI);
        }
    }

    public class CreateTests
    {
        [Fact]
        public void ThrowsArgumentExceptionWhenRadiusLessThenZero()
        {
            var func = () => Circle.Create(-1);

            func
                .Should()
                .Throw<ArgumentException>();
        }
    }
}