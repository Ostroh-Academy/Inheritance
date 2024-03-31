using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] coefficients = { 3.0, 4.0, 5.0 }; 
            double radius = 5.0; 

            Ball ball = new Ball(coefficients, radius); 

            
            ball.DisplayCoefficients(); 
            Console.WriteLine($"Об'єм кулі: {ball.CalculateVolume()}"); 

            Console.ReadLine(); 

            // Створюємо об'єкт класу Ellipsoid (еліпсоїд)
            double[] coefficientsEllipsoid = { 1.0, 2.0, 3.0 }; 
            double radiusEllipsoid = 5.0; 

            Ellipsoid ellipsoid = new Ellipsoid(coefficientsEllipsoid, radiusEllipsoid); 

            
            ellipsoid.DisplayCoefficients();
            Console.WriteLine($"Об'єм еліпса: {ellipsoid.CalculateVolume()}");

            Console.ReadLine();
        }

    }
}
