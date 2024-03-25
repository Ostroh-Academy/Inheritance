namespace Gl3;

public interface ICoordinateSystem
{
    void SetPolarCoordinates(double radius, double angle);
    void SetCartesianCoordinates(double x, double y);
    void PolarToCartesian(out double x, out double y);
    void CartesianToPolar(out double radius, out double angle);   
}