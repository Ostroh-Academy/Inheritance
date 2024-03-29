using System;

class FractionalFunction
{
    private double a1, a0, b1, b0;

    public FractionalFunction(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;
    }

    public void SetCoefficients(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;
    }

    public void PrintCoefficients()
    {
        Console.WriteLine($"Numerator coefficients: a1 = {a1}, a0 = {a0}");
        Console.WriteLine($"Denominator coefficients: b1 = {b1}, b0 = {b0}");
    }

    public double Evaluate(double x0)
    {
        double numerator = a1 * x0 + a0;
        double denominator = b1 * x0 + b0;
        if (denominator == 0)
        {
            throw new DivideByZeroException("Division by zero occurred.");
        }
        return numerator / denominator;
    }
}

class FractionalQuadraticFunction : FractionalFunction
{
    private double a2, b2;

    public FractionalQuadraticFunction(double a2, double a1, double a0, double b2, double b1, double b0) : base(a1, a0, b1, b0)
    {
        this.a2 = a2;
        this.b2 = b2;
    }

    public void SetCoefficients(double a2, double a1, double a0, double b2, double b1, double b0)
    {
        base.SetCoefficients(a1, a0, b1, b0);
        this.a2 = a2;
        this.b2 = b2;
    }

    public new void PrintCoefficients()
    {
        base.PrintCoefficients();
        Console.WriteLine($"Additional coefficients: a2 = {a2}, b2 = {b2}");
    }

    public new double Evaluate(double x0)
    {
        double linearPart = base.Evaluate(x0); 
        double numerator = a2 * x0 * x0 + linearPart;
        double denominator = b2 * x0 * x0 + linearPart;
        if (denominator == 0)
        {
            throw new DivideByZeroException("Division by zero occurred.");
        }
        return numerator / denominator;
    }
}

class FractionalFunctioN
{
    static void Main(string[] args)
    {
        FractionalFunction linearFunction = new FractionalFunction(1, 2, 3, 4);
        FractionalQuadraticFunction quadraticFunction = new FractionalQuadraticFunction(1, 2, 3, 4, 5, 6);

        Console.WriteLine("Linear Function:");
        linearFunction.PrintCoefficients();
        Console.WriteLine("Value at x = 2: " + linearFunction.Evaluate(2));

        Console.WriteLine("\nQuadratic Function:");
        quadraticFunction.PrintCoefficients();
        Console.WriteLine("Value at x = 2: " + quadraticFunction.Evaluate(2));
    }
}
