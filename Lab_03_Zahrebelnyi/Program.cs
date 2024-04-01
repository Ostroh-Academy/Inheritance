using Lab_03;

class Program
{
    static void Main(string[] args)
    {
        ShowConsole();
    }

    static void ShowConsole()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Виберіть операцію:");
        Console.WriteLine("1. Площа трикутника");
        Console.WriteLine("2. Проща опуклого чотирикутника");
        Console.WriteLine("3. Вихід");

        int option;
        if (int.TryParse(Console.ReadLine(), out option))
        {
            switch (option)
            {
                case 1:
                    OutputAreaTriangle();
                    break;
                case 2:
                    OutputAreaQuadrilateral();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Неправильний вибір. Спробуйте ще раз.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Неправильний ввід");
        }

        ShowConsole();
    }

    static void OutputAreaTriangle()
    {
        Console.WriteLine("Введіть х1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть х2");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть х3");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y1");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y2");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y3");
        double y3 = Convert.ToDouble(Console.ReadLine());

        Triangle triangle = new Triangle(x1, x2, x3, y1, y2, y3);
        triangle.OutputCoordinates(x1, x2, x3, y1, y2, y3);
        double s = triangle.OutputArea(x1, x2, x3, y1, y2, y3);

        Console.WriteLine($"Площа: {s}");
    }

    static void OutputAreaQuadrilateral()
    {
        Console.WriteLine("Введіть х1");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть х2");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть х3");
        double x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть х4");
        double x4 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y1");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y2");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y3");
        double y3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введіть y4");
        double y4 = Convert.ToDouble(Console.ReadLine());

        Quadrilateral quadrilateral = new Quadrilateral(x1, x2, x3, x4, y1, y2, y3, y4);
        quadrilateral.OutputCoordinates(x1, x2, x3, x4, y1, y2, y3, y4);
        double s = quadrilateral.OutputArea(x1, x2, x3, x4, y1, y2, y3, y4);

        Console.WriteLine($"Площа: {s}");
    }
}