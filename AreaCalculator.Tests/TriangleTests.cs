using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator.Tests
{
    [TestFixture]
    class TriangleTests
    {
        [Test]
        public void GetArea_ValidParameters_ReturnCorrectResult()
        {
            Triangle triangle = new Triangle(3, 4, 5);
            Assert.AreEqual(6, triangle.GetArea());
        }

        [Test]
        public void GetArea_InvalidParameters_ReturnMinusOne()
        {
            Triangle triangle1 = new Triangle(-1, 0, 5);
            Assert.AreEqual(-1, triangle1.GetArea());

            Triangle triangle2 = new Triangle(1, 3, 1);
            Assert.AreEqual(-1, triangle1.GetArea());
        }
    }
}
