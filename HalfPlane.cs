using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class HalfPlane
    {
        protected double[] coefficients;
        public HalfPlane() : this(0, 0, 0)
        { }
        public HalfPlane(double a1, double a2, double b)
        {
            coefficients = new double[] { a1, a2, b };
        }

        public void SetCoefficients(double a1, double a2, double b)
        {
            coefficients[0] = a1;
            coefficients[1] = a2;
            coefficients[2] = b;
        }

        public virtual void DisplayCoefficients()
        {
            Console.WriteLine($"Coefficients: {coefficients[0]}, {coefficients[1]}, {coefficients[2]}");
        }

        public virtual bool IsPointInside(double[] x)
        {
            return x[0] * coefficients[0] + x[1] * coefficients[1] < coefficients[2];
        }
    }
}
