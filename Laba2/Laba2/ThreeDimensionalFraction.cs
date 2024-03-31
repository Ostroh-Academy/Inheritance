using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2
{
    public class ThreeDimensionalFraction : Fraction
    {
        private double a2;
        private double a3;

        public ThreeDimensionalFraction(double coefficient, double coefficient2, double coefficient3) : base(coefficient)
        {
            a2 = coefficient2;
            a3 = coefficient3;
        }

        public void SetCoefficients(double coefficient, double coefficient2, double coefficient3)
        {
            SetCoefficient(coefficient);
            a2 = coefficient2;
            a3 = coefficient3;
        }

        public new void PrintCoefficient()
        {
            Console.WriteLine("Coefficient a: " + a);
            Console.WriteLine("Coefficient a2: " + a2);
            Console.WriteLine("Coefficient a3: " + a3);
        }

        public new double CalculateFractionValue(double x)
        {
            return 1 / (a * x + 1 / (a2 * x + 1 / a3 * x));
        }
    }
}
