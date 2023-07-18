namespace AreaCalculator;

using System;

public class Circle : IShape
{
    private double radius;

    private Circle(
        double radius)
    {
        this.radius = radius;
    }

    public static Circle Create(
        double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException();
        }

        return new Circle(
            radius: radius);
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }
}

