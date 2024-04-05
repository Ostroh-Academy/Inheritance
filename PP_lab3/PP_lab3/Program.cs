using System;

// Клас Трикутник
class Triangle
{
    // Координати вершин трикутника
    private double[] x = new double[3];
    private double[] y = new double[3];

    // Метод для задання координат вершин трикутника
    public void SetVertices(double x1, double y1, double x2, double y2, double x3, double y3)
    {
        x[0] = x1;
        y[0] = y1;
        x[1] = x2;
        y[1] = y2;
        x[2] = x3;
        y[2] = y3;
    }

    // Метод для виведення координат вершин на екран
    public void PrintVertices()
    {
        Console.WriteLine("Triangle vertices:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Vertex {0}: ({1}, {2})", i + 1, x[i], y[i]);
        }
    }

    // Метод для обчислення площі трикутника
    public double CalculateArea()
    {
        double area = Math.Abs((x[0] * (y[1] - y[2]) + x[1] * (y[2] - y[0]) + x[2] * (y[0] - y[1])) / 2);
        return area;
    }
}

// Похідний клас Опуклий чотирикутник
class ConvexQuadrilateral : Triangle
{
    // Додаткові координати вершин для четвертої вершини чотирикутника
    private double x4, y4;

    // Перевизначений метод для задання координат вершин опуклого чотирикутника
    public void SetVertices(double x1, double y1, double x2, double y2, double x3, double y3, double x4, double y4)
    {
        base.SetVertices(x1, y1, x2, y2, x3, y3);
        this.x4 = x4;
        this.y4 = y4;
    }

    // Перевизначений метод для виведення координат вершин опуклого чотирикутника
    public new void PrintVertices()
    {
        base.PrintVertices();
        Console.WriteLine("Vertex 4: ({0}, {1})", x4, y4);
    }

    // Перевизначений метод для обчислення площі опуклого чотирикутника
    public new double CalculateArea()
    {
        // Розділяємо чотирикутник на два трикутники і обчислюємо їх площі
        double area1 = base.CalculateArea();
        double area2 = Math.Abs((x[2] * (y4 - y[0]) + x4 * (y[0] - y[1]) + x[0] * (y[1] - y4)) / 2);

        return area1 + area2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Створення об'єкта трикутника
        Triangle triangle = new Triangle();
        triangle.SetVertices(0, 0, 3, 0, 0, 4);
        triangle.PrintVertices();
        Console.WriteLine("Triangle area: {0}", triangle.CalculateArea());

        Console.WriteLine();

        // Створення об'єкта опуклого чотирикутника
        ConvexQuadrilateral quadrilateral = new ConvexQuadrilateral();
        quadrilateral.SetVertices(0, 0, 4, 0, 4, 3, 0, 3);
        quadrilateral.PrintVertices();
        Console.WriteLine("Convex quadrilateral area: {0}", quadrilateral.CalculateArea());
    }
}