using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using AreaCalculator;

namespace AreaCalculator.Tests
{
    [TestFixture]
    class CircleTests
    {
        [Test]
        public void GetArea_ValidParameters_ReturnCorrectResult()
        {
            Circle circle = new Circle(5);
            Assert.AreEqual(5 * 5 * Math.PI, circle.GetArea());
        }

        [Test]
        public void GetArea_InvalidParameters_ReturnMinusOne()
        {
            Circle circle = new Circle(-5);
            Assert.AreEqual(-1, circle.GetArea());
        }
    }
}
