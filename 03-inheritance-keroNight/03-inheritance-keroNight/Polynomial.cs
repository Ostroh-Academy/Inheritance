namespace _03_inheritance_keroNight;

public class Polynomial : LinearFunction
{
    public Polynomial() => 
        coefficients = new double[5]; // для многочлена a4x^4 + a3x^3 + a2x^2 + a1x + a0

    public void SetCoefficients(double a)
    {
        for (var i = 0; i < 5; i++) 
            coefficients[i] = a;
    }

    public new void DisplayCoefficients()
    {
        Console.WriteLine("Polynomial Coefficients:");
        Console.WriteLine("a: " + coefficients[0]);
    }

    public new double CalculateValue(double x)
    {
        double result = 0;
        for (var i = 0; i < 5; i++) 
            result += coefficients[i] * Math.Pow(x, 4 - i);
        
        return result;
    }
}