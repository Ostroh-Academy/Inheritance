namespace Gl3;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        PolarCoordinateSystem polarSystem = new PolarCoordinateSystem();
        polarSystem.SetPolarCoordinates(5, Math.PI / 3);
        
        CylindricalCoordinateSystem cylindricalSystem = new CylindricalCoordinateSystem();
        cylindricalSystem.SetCylindricalCoordinates(3, Math.PI / 4, 2);

        // Перетворення полярних координат в декартові
        double x1, y1;
        polarSystem.PolarToCartesian(out x1, out y1);
        Console.WriteLine($"Полярні координати: (radius = {polarSystem.radius}, angle = {polarSystem.angle})");
        Console.WriteLine($"Декартові координати: (x = {x1}, y = {y1})");

        // Перетворення циліндричних координат в декартові
        double x2, y2, z2;
        cylindricalSystem.CylindricalToCartesian(out x2, out y2, out z2);
        Console.WriteLine($"Циліндричні координати: (radius = {cylindricalSystem.radius}, angle = {cylindricalSystem.angle}, z = {cylindricalSystem.z})");
        Console.WriteLine($"Декартові координати: (x = {x2}, y = {y2}, z = {z2})");
    }
}