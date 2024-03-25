using System;

public class LinearFunction
{
    protected double a1;
    protected double a0;

    public LinearFunction(double a1, double a0)
    {
        this.a1 = a1;
        this.a0 = a0;
    }

    public void SetCoefficients(double a1, double a0)
    {
        this.a1 = a1;
        this.a0 = a0;
    }

    public void PrintCoefficients()
    {
        Console.WriteLine($"a1: {a1}");
        Console.WriteLine($"a0: {a0}");
    }

    public double CalculateValue(double x)
    {
        return a1 * x + a0;
    }
}

public class Polynomial
{
    private double a4;
    private double a3;
    private double a2;
    private double a1;
    private double a0;

    public Polynomial(double a4, double a3, double a2, double a1, double a0)
    {
        this.a4 = a4;
        this.a3 = a3;
        this.a2 = a2;
        this.a1 = a1;
        this.a0 = a0;
    }

    public void SetCoefficients(double a4, double a3, double a2, double a1, double a0)
    {
        this.a4 = a4;
        this.a3 = a3;
        this.a2 = a2;
        this.a1 = a1;
        this.a0 = a0;
    }

    public void PrintCoefficients()
    {
        Console.WriteLine($"a4: {a4}");
        Console.WriteLine($"a3: {a3}");
        Console.WriteLine($"a2: {a2}");
        Console.WriteLine($"a1: {a1}");
        Console.WriteLine($"a0: {a0}");
    }

    public double CalculateValue(double x)
    {
        return a4 * Math.Pow(x, 4) + a3 * Math.Pow(x, 3) + a2 * Math.Pow(x, 2) + a1 * x + a0;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть коефіцієнти для лінійної функції (a1, a0): ");
        double a1 = double.Parse(Console.ReadLine());
        double a0 = double.Parse(Console.ReadLine());

        LinearFunction linearFunction = new LinearFunction(a1, a0);

        Console.WriteLine("Введіть значення x для лінійної функції: ");
        double xLinear = double.Parse(Console.ReadLine());

        Console.WriteLine("Введіть коефіцієнти полінома (a4, a3, a2, a1, a0): ");
        double a4 = double.Parse(Console.ReadLine());
        double a3 = double.Parse(Console.ReadLine());
        double a2 = double.Parse(Console.ReadLine());
        double a1Poly = double.Parse(Console.ReadLine());
        double a0Poly = double.Parse(Console.ReadLine());

        Polynomial polynomial = new Polynomial(a4, a3, a2, a1Poly, a0Poly);

        Console.WriteLine("Введіть значення x для полінома: ");
        double xPoly = double.Parse(Console.ReadLine());

        double linearFunctionValue = linearFunction.CalculateValue(xLinear);
        double polynomialValue = polynomial.CalculateValue(xPoly);

        Console.WriteLine($"Значення лінійної функції при {xLinear}: {linearFunctionValue}");
        Console.WriteLine($"Значення полінома при {xPoly}: {polynomialValue}");
    }
}