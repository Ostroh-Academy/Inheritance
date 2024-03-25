using System;

class RightTriangle
{
    protected double side1;
    protected double side2;

    public RightTriangle(double side1, double side2)
    {
        this.side1 = side1;
        this.side2 = side2;
    }

    public double CalculatePerimeter()
    {
        return side1 + side2 + Math.Sqrt(side1 * side1 + side2 * side2);
    }
}

class Triangle : RightTriangle
{
    private double angle;

    public Triangle(double side1, double side2, double angle) : base(side1, side2)
    {
        this.angle = angle;
    }

    public void SetSideAndAngles(double side, double angle1, double angle2)
    {
        side1 = side;
        side2 = side * Math.Sin(angle1 * Math.PI / 180) / Math.Sin(angle2 * Math.PI / 180);
        angle = 180 - angle1 - angle2;
    }

    public double GetAngle()
    {
        return angle;
    }

    public double GetSide1()
    {
        return side1;
    }

    public double GetSide2()
    {
        return side2;
    }

    public double CalculatePerimeter()
    {
        return side1 + side2 + Math.Sqrt(side1 * side1 + side2 * side2 - 2 * side1 * side2 * Math.Cos(angle * Math.PI / 180));
    }
}

class Program
{
    static void Main(string[] args)
    {
        RightTriangle rightTriangle = new RightTriangle(3, 4);
        Triangle triangle = new Triangle(5, 6, 90);

        Console.WriteLine("Прямокутний трикутник:");
        Console.WriteLine("Периметр: " + rightTriangle.CalculatePerimeter());

        Console.WriteLine("\nТрикутник:");
        Console.WriteLine("Кут: " + triangle.GetAngle());
        Console.WriteLine("Сторона1: " + triangle.GetSide1());
        Console.WriteLine("Сторона2: " + triangle.GetSide2());
        Console.WriteLine("Периметр: " + triangle.CalculatePerimeter());
    }
}
