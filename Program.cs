namespace Practice3;

public class Program
{
    public static void Main(string[] args)
    {
        var f = new Fraction(2, 3);

        Console.WriteLine(f.ValueAt());
        Console.WriteLine(f.ToString());

        var f3d = new Fraction3D([2, 3, 4], 2);
        
        Console.WriteLine(f3d.ValueAt());
        Console.WriteLine(f3d.ToString());
    }
}

public class Fraction
{
    public double Denominator { get; set; }
    public double X { get; set; }

    public Fraction(double denominator, double x)
    {
        Denominator = denominator;
        X = x;
    }

    public virtual double ValueAt() => 1.0 / (Denominator * X);

    public override string ToString() => $"Numerator: {1.0}, a: {Denominator}, x: {X}";
}

public class Fraction3D : Fraction
{
    public List<double> Denominators { get; set; }

    public Fraction3D(List<double> denominators, double x) : base(2, x)
    {
        Denominators = denominators;
    }

    public override double ValueAt()
    {
        return 1.0 / (Denominators[0] * X + (1.0 / (Denominators[1] * X + (1.0 / (Denominators[2] * X)))));
        //return 1.0 / (Denominators[0] * X + (1.0 / (Denominators[1] * X + 1.0 / (Denominators[2] * X))));
    }

    public override string ToString() =>
        $"Numerator: {1.0}, a1: {Denominators[0]}, a2: {Denominators[1]}, a3: {Denominators[3]}";
}