using System.Numerics;

namespace Lab_03
{
    class Triangle
    {
        protected double x1, x2, x3, y1, y2, y3;

        public Triangle(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;

            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public void InputCoordinates(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;

            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
        }

        public void OutputCoordinates(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            Console.WriteLine($"Вершина 1 = [{x1},{y1}], Вершина 2 = [{x2},{y2}], Вершина 3 = [{x3},{y3}]");
        }

        public double OutputArea(double x1, double x2, double x3, double y1, double y2, double y3)
        {
            double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
            double c = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));

            double p = (a + b + c) / 2;

            double s = Math.Sqrt(p * (p - a) * (p - b) + (p - c));

            return s;
        }
    }
}