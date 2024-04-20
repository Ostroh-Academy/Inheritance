using System;

public class CylindricalCoordinateSystem : PolarCoordinateSystem
{
    public double Height { get; private set; }

    public CylindricalCoordinateSystem(double radius, double angle, double height) : base(radius, angle)
    {
        Height = height;
    }

    public void SetCylindricalCoordinates(double radius, double angle, double height)
    {
        SetPolarCoordinates(radius, angle);
        Height = height;
    }

    public void SetCartesianCoordinates(double x, double y, double z)
    {
        SetCartesianCoordinates(x, y); 
        Height = z;
    }

    public (double X, double Y, double Z) ConvertToCartesian()
    {
        var (x, y) = base.ConvertToCartesian(); 
        return (x, y, Height);
    }

    public void ConvertToCylindrical(double x, double y, double z)
    {
        SetCartesianCoordinates(x, y); 
        Height = z;
    }
}
