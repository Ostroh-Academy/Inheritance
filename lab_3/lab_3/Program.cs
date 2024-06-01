using System;

namespace TransformationApp
{
    public class PlaneTransformation
    {
        // Коефіцієнти перетворення
        private double a11, a12, a13;
        private double a21, a22, a23;

        // Конструктор з початковими значеннями коефіцієнтів
        public PlaneTransformation(double a11, double a12, double a13, double a21, double a22, double a23)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a13 = a13;
            this.a21 = a21;
            this.a22 = a22;
            this.a23 = a23;
        }

        // Метод для задання коефіцієнтів перетворення
        public void SetCoefficients(double a11, double a12, double a13, double a21, double a22, double a23)
        {
            this.a11 = a11;
            this.a12 = a12;
            this.a13 = a13;
            this.a21 = a21;
            this.a22 = a22;
            this.a23 = a23;
        }

        // Метод для виведення коефіцієнтів перетворення на екран
        public void PrintCoefficients()
        {
            Console.WriteLine($"a11 = {a11}, a12 = {a12}, a13 = {a13}");
            Console.WriteLine($"a21 = {a21}, a22 = {a22}, a23 = {a23}");
        }

        // Метод для визначення образу заданої точки (x, y)
        public (double x, double y) TransformPoint(double x, double y)
        {
            double xPrime = a11 * x + a12 * y + a13;
            double yPrime = a21 * x + a22 * y + a23;
            return (xPrime, yPrime);
        }
    }

    public class SpaceTransformation : PlaneTransformation
    {
        // Додаткові коефіцієнти для перетворення простору
        private double a31, a32, a33, a34;
        private double a41, a42, a43, a44;

        // Конструктор з початковими значеннями коефіцієнтів
        public SpaceTransformation(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33, double a34)
            : base(a11, a12, a13, a21, a22, a23)
        {
            this.a31 = a31;
            this.a32 = a32;
            this.a33 = a33;
            this.a34 = a34;
        }

        // Перевантажений метод для задання коефіцієнтів перетворення простору
        public void SetCoefficients(double a11, double a12, double a13, double a21, double a22, double a23, double a31, double a32, double a33, double a34)
        {
            SetCoefficients(a11, a12, a13, a21, a22, a23);
            this.a31 = a31;
            this.a32 = a32;
            this.a33 = a33;
            this.a34 = a34;
        }

        // Перевантажений метод для виведення коефіцієнтів перетворення на екран
        public new void PrintCoefficients()
        {
            base.PrintCoefficients();
            Console.WriteLine($"a31 = {a31}, a32 = {a32}, a33 = {a33}, a34 = {a34}");
        }

        // Метод для визначення образу заданої точки (x, y, z)
        public (double x, double y, double z) TransformPoint(double x, double y, double z)
        {
            double xPrime = base.TransformPoint(x, y).x + a34;
            double yPrime = base.TransformPoint(x, y).y + a34;
            double zPrime = a31 * x + a32 * y + a33 * z + a34;
            return (xPrime, yPrime, zPrime);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Створення об'єкта класу PlaneTransformation
            PlaneTransformation planeTransformation = new PlaneTransformation(1, 2, 3, 4, 5, 6);
            planeTransformation.PrintCoefficients();

            // Введення точки користувачем
            Console.WriteLine("Введіть координати точки (x, y): ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());

            // Визначення образу точки
            var transformedPoint = planeTransformation.TransformPoint(x, y);
            Console.WriteLine($"Образ точки ({x}, {y}) -> ({transformedPoint.x}, {transformedPoint.y})");

            // Створення об'єкта класу SpaceTransformation
            SpaceTransformation spaceTransformation = new SpaceTransformation(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            spaceTransformation.PrintCoefficients();

            // Введення точки користувачем
            Console.WriteLine("Введіть координати точки (x, y, z): ");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            double z = Convert.ToDouble(Console.ReadLine());

            // Визначення образу точки
            var transformedPoint3D = spaceTransformation.TransformPoint(x, y, z);
            Console.WriteLine($"Образ точки ({x}, {y}, {z}) -> ({transformedPoint3D.x}, {transformedPoint3D.y}, {transformedPoint3D.z})");
        }
    }
}
