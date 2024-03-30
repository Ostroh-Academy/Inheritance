
using Triangles;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side length of the equilateral triangle:");
        double sideLengthEquilateral = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Equilateral Triangle Characteristics:");
        EquilateralTriangle equilateralTriangle = new EquilateralTriangle();
        equilateralTriangle.SetValues(sideLengthEquilateral, 60);

        Console.WriteLine("Side Lengths: " + string.Join(", ", equilateralTriangle.GetSideLengths()));
        Console.WriteLine("Perimeter: " + equilateralTriangle.CalculatePerimeter());
        Console.WriteLine();

        Console.WriteLine("Enter side length of the triangle:");
        double sideLengthTriangle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter first angle of the triangle:");
        double firstAngleTriangle = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter second angle of the triangle:");
        double secondAngleTriangle = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Triangle Characteristics:");
        Triangle triangle = new Triangle();
        triangle.SetValues(sideLengthTriangle, firstAngleTriangle, secondAngleTriangle);
        Console.WriteLine("Side Lengths: " + string.Join(", ", triangle.GetSideLengths()));
        Console.WriteLine("Angles: " + string.Join(", ", triangle.GetAngles()));
        Console.WriteLine("Perimeter: " + triangle.CalculatePerimeter());
    }
}