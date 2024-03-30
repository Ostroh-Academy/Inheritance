namespace Triangles
{
    public class Triangle : EquilateralTriangle
    {
        public double secondAngle;

        public new void SetValues(double sideLength, double firstAngle, double secondAngle)
        {
            base.SetValues(sideLength, firstAngle);
            this.secondAngle = secondAngle;
        }

        public override double[] GetSideLengths()
        {
            double[] sideLengths = new double[3];
            sideLengths[0] = sideLength;
            sideLengths[1] = Math.Round((sideLength * Math.Sin(Math.PI * secondAngle / 180)) / Math.Sin(Math.PI * angle / 180));
            sideLengths[2] = Math.Round((sideLength * Math.Sin(Math.PI * (180 - angle - secondAngle) / 180)) / Math.Sin(Math.PI * angle / 180));
            return sideLengths;
        }

        public double[] GetAngles()
        {
             
            return new double[] { angle, (180 - angle - secondAngle), secondAngle };
        }

        public override double CalculatePerimeter()
        {

            double[] sideLengths = GetSideLengths();
            double perimeter = 0;
            foreach (double side in sideLengths)
            {
                perimeter += side;
            }
            return perimeter;
        }
    }
}
