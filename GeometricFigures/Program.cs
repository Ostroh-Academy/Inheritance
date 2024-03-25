using GeometricFigures.Entities;

namespace GeometricFigures;

internal static class Program
{
    private static void Main()
    {
        var point1 = new Point3D(0, 0, 0);
        var point2 = new Point3D(1, 0, 0);
        var point3 = new Point3D(0, 1, 0);
        var point4 = new Point3D(0, 0, 1);

        var triangle = new Triangle();
        var tetrahedron = new Tetrahedron();

        triangle.SetCoordinates(point1, point2, point3);
        Console.WriteLine($"Triangle: \n\n{triangle.PrintCoordinates()}");
        Console.WriteLine($"Area of the triangle: {triangle.CalculateArea():F2}");
        
        tetrahedron.SetCoordinates(point1, point2, point3, point4);
        Console.WriteLine($"\nTetrahedron: \n\n{tetrahedron.PrintCoordinates()}");
        Console.WriteLine($"Volume of the tetrahedron: {tetrahedron.CalculateArea():F2}");
    }
}