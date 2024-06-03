using System;

public class PolarCoordinateSystem
{
    public double Radius { get; private set; }
    public double Angle { get; private set; }

    public PolarCoordinateSystem(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }

    public void SetPolarCoordinates(double radius, double angle)
    {
        Radius = radius;
        Angle = angle;
    }

    public void SetCartesianCoordinates(double x, double y)
    {
        Radius = Math.Sqrt(x * x + y * y);
        Angle = Math.Atan2(y, x);
    }

    public (double X, double Y) ConvertToCartesian()
    {
        double x = Radius * Math.Cos(Angle);
        double y = Radius * Math.Sin(Angle);
        return (x, y);
    }

    public (double Radius, double Angle) ConvertToPolar(double x, double y)
    {
        double radius = Math.Sqrt(x * x + y * y);
        double angle = Math.Atan2(y, x);
        return (radius, angle);
    }
}
