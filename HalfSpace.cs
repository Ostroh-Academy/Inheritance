using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class HalfSpace : HalfPlane
    {
        public HalfSpace() : this(0, 0, 0, 0)
        { }
        public HalfSpace(double a1, double a2, double a3, double b)
        {
            coefficients = new double[] { a1, a2, a3, b };
        }

        public void SetCoefficients(double a1, double a2, double a3, double b)
        {
            coefficients[0] = a1;
            coefficients[1] = a2;
            coefficients[2] = a3;
            coefficients[3] = b;
        }

        public override void DisplayCoefficients()
        {
            Console.WriteLine($"Coefficients: {coefficients[0]}, {coefficients[1]}, {coefficients[2]}, {coefficients[3]}");
        }

        public override bool IsPointInside(double[] x)
        {
            return x[0] * coefficients[0] + x[1] * coefficients[1] + x[2] * coefficients[2] <= coefficients[3];
        }
    }
}
