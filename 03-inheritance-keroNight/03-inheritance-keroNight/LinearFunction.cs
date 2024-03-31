namespace _03_inheritance_keroNight;

public class LinearFunction
{
    protected double[] coefficients;

    public LinearFunction() => 
        coefficients = new double[2]; // для лінійної функції y = a1x + a0

    public void SetCoefficients(double a, double b)
    {
        coefficients[0] = a;
        coefficients[1] = b;
    }

    public void DisplayCoefficients()
    {
        Console.WriteLine("Linear Function Coefficients:");
        Console.WriteLine("Slope (m): " + coefficients[0]);
        Console.WriteLine("Intercept (c): " + coefficients[1]);
    }

    public double CalculateValue(double x) => 
        coefficients[0] * x + coefficients[1];
}