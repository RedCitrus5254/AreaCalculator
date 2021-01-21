using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            if (radius < 0)
            {
                return -1;
            }

            return Math.PI * radius * radius;
        }
    }
}
