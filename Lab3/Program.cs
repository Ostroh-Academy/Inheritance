using System;

class Ellipse
{
    protected double a, b; 
    public Ellipse(double a, double b)
    {
        this.a = a;
        this.b = b;
    }

    public void PrintCoefficients()
    {
        Console.WriteLine($"Коефіцієнти еліпса: a = {a}, b = {b}");
    }

    public bool PointBelongsToEllipse(double x, double y)
    {
        return (x * x) / (a * a) + (y * y) / (b * b) <= 1;
    }
}

class SecondOrderCurve : Ellipse
{
    private double a11, a12, a22, b1, b2, c; 

    public SecondOrderCurve(double a11, double a12, double a22, double b1, double b2, double c)
        : base(0, 0) 
    {
        this.a11 = a11;
        this.a12 = a12;
        this.a22 = a22;
        this.b1 = b1;
        this.b2 = b2;
        this.c = c;
    }

    public new void PrintCoefficients()
    {
        Console.WriteLine($"Коефіцієнти кривої другого порядку: a11 = {a11}, a12 = {a12}, a22 = {a22}, b1 = {b1}, b2 = {b2}, c = {c}");
    }

    public bool PointBelongsToCurve(double x, double y)
    {
        return a11 * x * x + 2 * a12 * x * y + a22 * y * y + b1 * x + b2 * y + c == 0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Ellipse ellipse = new Ellipse(1, 20);
        ellipse.PrintCoefficients();

        Console.Write("Введіть координату x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введіть координату y: ");
        double y = double.Parse(Console.ReadLine());

        if (ellipse.PointBelongsToEllipse(x, y))
            Console.WriteLine($"Точка ({x}, {y}) належить еліпсу.");
        else
            Console.WriteLine($"Точка ({x}, {y}) не належить еліпсу.");

        SecondOrderCurve curve = new SecondOrderCurve(1, 2, 3, 4, 5, 6);
        curve.PrintCoefficients();

        if (curve.PointBelongsToCurve(x, y))
            Console.WriteLine($"Точка ({x}, {y}) належить кривій другого порядку.");
        else
            Console.WriteLine($"Точка ({x}, {y}) не належить кривій другого порядку.");
    }
}

