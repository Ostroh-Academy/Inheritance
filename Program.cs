using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        PolarCoordinateSystem polarSystem = new PolarCoordinateSystem(5, Math.PI / 3);

        Console.WriteLine($"Початкові полярні координати: (r={polarSystem.Radius}, θ={polarSystem.Angle})");

        polarSystem.SetPolarCoordinates(8, Math.PI / 4);

        Console.WriteLine($"Нові полярні координати: (r={polarSystem.Radius}, θ={polarSystem.Angle})");

        var (x1, y1) = polarSystem.ConvertToCartesian();
        Console.WriteLine($"Координати в декартовій системі: ({x1}, {y1})");

        CylindricalCoordinateSystem cylindricalSystem = new CylindricalCoordinateSystem(3, Math.PI / 4, 5);

        Console.WriteLine($"Початкові циліндричні координати: (r={cylindricalSystem.Radius}, θ={cylindricalSystem.Angle}, h={cylindricalSystem.Height})");

        cylindricalSystem.SetCylindricalCoordinates(6, Math.PI / 3, 7);

        Console.WriteLine($"Нові циліндричні координати: (r={cylindricalSystem.Radius}, θ={cylindricalSystem.Angle}, h={cylindricalSystem.Height})");

        var (x2, y2, z2) = cylindricalSystem.ConvertToCartesian();
        Console.WriteLine($"Координати в декартовій системі: ({x2}, {y2}, {z2})");

        cylindricalSystem.ConvertToCylindrical(4, 4, 5);
        Console.WriteLine($"Циліндричні координати після перетворення: (r={cylindricalSystem.Radius}, θ={cylindricalSystem.Angle}, h={cylindricalSystem.Height})");
    }
}
