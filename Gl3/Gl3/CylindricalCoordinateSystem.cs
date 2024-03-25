namespace Gl3;

class CylindricalCoordinateSystem : PolarCoordinateSystem
{
    internal double z;

    public void SetCylindricalCoordinates(double radius, double angle, double z)
    {
        SetPolarCoordinates(radius, angle);
        this.z = z;
    }

    public void SetCartesianCoordinates(double x, double y, double z)
    {
        this.z = z;
        base.SetCartesianCoordinates(x, y);
    }

    public void CylindricalToCartesian(out double x, out double y, out double z)
    {
        base.PolarToCartesian(out x, out y);
        z = this.z;
    }

    public void CartesianToCylindrical(out double radius, out double angle, out double z)
    {
        base.CartesianToPolar(out radius, out angle);
        z = this.z;
    }
}