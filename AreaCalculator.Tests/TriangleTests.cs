namespace AreaCalculator.Tests;

using FluentAssertions;
using Xunit;

public class TriangleTests
{
    public class CalculateAreaTests
    {
        [Fact]
        public void CalculatesCorrectly()
        {
            var triangle = Triangle.Create(a: 3, b: 4, c: 5);

            var actual = triangle.CalculateArea();

            actual
                .Should()
                .Be(6);
        }
    }

    public class CreateTests
    {
        [Fact]
        public void ThrowsArgumentExceptionWhenSideLessThenZero()
        {
            var func = () => Triangle.Create(a: -1, b: 4, c: 5);

            func
                .Should()
                .Throw<ArgumentException>();
        }

        [Fact]
        public void ThrowsArgumentExceptionWhenNotTriangle()
        {
            var func = () => Triangle.Create(a: 1, b: 1, c: 500);

            func
                .Should()
                .Throw<ArgumentException>();
        }
    }

    public class IsRectangularTests
    {
        [Fact]
        public void TrueWhenRectangular()
        {
            var triangle = Triangle.Create(a: 3, b: 4, c: 5);

            triangle
                .IsRectangular()
                .Should()
                .Be(true);
        }

        [Fact]
        public void FalseWhenNotRectangular()
        {
            var triangle = Triangle.Create(a: 1, b: 1, c: 1);

            triangle
                .IsRectangular()
                .Should()
                .Be(false);
        }
    }
}