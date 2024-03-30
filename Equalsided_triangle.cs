namespace Triangles
{
    public class EquilateralTriangle
    {
        public double sideLength;
        public double angle;

        public virtual void SetValues(double sideLength, double angle)
        {
            this.sideLength = sideLength;
            this.angle = angle;
        }

        public virtual double[] GetSideLengths()
        {
            return new double[] { sideLength, sideLength, sideLength };
        }

        public virtual double CalculatePerimeter()
        {
            return 3 * sideLength;
        }
    }
}