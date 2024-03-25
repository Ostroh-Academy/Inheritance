namespace Gl3;

class PolarCoordinateSystem : ICoordinateSystem
{
    protected internal double radius;
    protected internal double angle;

    public void SetPolarCoordinates(double radius, double angle)
    {
        this.radius = radius;
        this.angle = angle;
    }

    public void SetCartesianCoordinates(double x, double y)
    {
        radius = Math.Sqrt(x * x + y * y);
        angle = Math.Atan2(y, x);
    }

    public void PolarToCartesian(out double x, out double y)
    {
        x = radius * Math.Cos(angle);
        y = radius * Math.Sin(angle);
    }

    public void CartesianToPolar(out double radius, out double angle)
    {
        radius = this.radius;
        angle = this.angle;
    }
}