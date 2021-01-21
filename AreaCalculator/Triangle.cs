using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Triangle : IShape
    {
        private double A;
        private double B;
        private double C;

        public Triangle(double ASide, double BSide, double CSide)
        {
            A = ASide;
            B = BSide;
            C = CSide;
        }

        public double GetArea()
        {
            if (A <= 0 || B <= 0 || C <= 0)
            {
                return -1;
            }
            if (C > A + B || A > B + C || B > A + C)
            {
                return -1;
            }

            double halfPerimeter = (A + B + C) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - A) * (halfPerimeter - B) * (halfPerimeter - C));
            return area;
        }
    }
}
