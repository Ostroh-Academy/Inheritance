using System;

namespace Geometry
{
    class Kula
    {
        protected double b1, b2, b3, R;

        public Kula(double b1 = 0, double b2 = 0, double b3 = 0, double R = 1)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.R = R;
        }

        public void SetCoefficients(double b1, double b2, double b3, double R)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.R = R;
        }

        public void DisplayCoefficients()
        {
            Console.WriteLine($"Center: ({b1}, {b2}, {b3}), Radius: {R}");
        }

        public double Volume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(R, 3);
        }
    }

    class Elipsoid : Kula
    {
        private double a1, a2, a3;

        public Elipsoid(double b1 = 0, double b2 = 0, double b3 = 0, double a1 = 1, double a2 = 1, double a3 = 1)
            : base(b1, b2, b3, 1)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }

        public void SetCoefficients(double b1, double b2, double b3, double a1, double a2, double a3)
        {
            this.b1 = b1;
            this.b2 = b2;
            this.b3 = b3;
            this.a1 = a1;
            this.a2 = a2;
            this.a3 = a3;
        }

        public new void DisplayCoefficients()
        {
            Console.WriteLine($"Center: ({b1}, {b2}, {b3}), Semi-axes: a1={a1}, a2={a2}, a3={a3}");
        }

        public new double Volume()
        {
            return (4.0 / 3.0) * Math.PI * a1 * a2 * a3;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kula kula = new Kula(1, 2, 3, 4);
            kula.DisplayCoefficients();
            Console.WriteLine($"Volume of the sphere: {kula.Volume()}");

            Elipsoid elipsoid = new Elipsoid(1, 2, 3, 4, 5, 6);
            elipsoid.DisplayCoefficients();
            Console.WriteLine($"Volume of the ellipsoid: {elipsoid.Volume()}");
        }
    }
}
