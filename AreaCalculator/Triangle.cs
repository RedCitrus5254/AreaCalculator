namespace AreaCalculator;

using System;

public class Triangle : IShape
{
    private readonly double a;
    private readonly double b;
    private readonly double c;

    private Triangle(
        double a,
        double b,
        double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public static Triangle Create(
        double a,
        double b,
        double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException();
        }

        if (c > a + b || a > b + c || b > a + c)
        {
            throw new ArgumentException();
        }

        return new Triangle(
            a: a,
            b: b,
            c: c);
    }

    public double CalculateArea()
    {
        var halfPerimeter = (a + b + c) / 2;

        return Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
    }

    public bool IsRectangular()
    {
        if (a * a == b * b + c * c ||
            b * b == a * a + c * c ||
            c * c == a * a + b * b)
        {
            return true;
        }

        return false;
    }
}
