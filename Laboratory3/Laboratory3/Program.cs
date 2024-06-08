using Laboratory3.Core;

namespace Laboratory3;

internal static class Program
{
    private static void Main(string[] args)
    {
        EquilateralTriangle equilateralTriangle = new(5.0);
        ShowTriangleParameters(equilateralTriangle);
        
        Triangle triangle = new(4.0, 60.0, 45.0);
        ShowTriangleParameters(triangle);
    }

    private static void ShowTriangleParameters(EquilateralTriangle triangle)
    {
        Console.WriteLine($"{triangle.GetType().Name}:");
        Console.WriteLine($"Side length 1: {triangle.GetSide1()}");
        Console.WriteLine($"Side length 2: {triangle.GetSide2()}");
        Console.WriteLine($"Side length 3: {triangle.GetSide3()}");
        Console.WriteLine($"Angle 1: {triangle.GetAngle1()}");
        Console.WriteLine($"Angle 2: {triangle.GetAngle2()}");
        Console.WriteLine($"Angle 3: {triangle.GetAngle3()}");
        Console.WriteLine($"Perimeter: {triangle.GetPerimeter()}");
        Console.WriteLine();
    }
}