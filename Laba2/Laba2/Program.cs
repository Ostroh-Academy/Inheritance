using Laba2;
using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new Fraction(2);
        fraction.PrintCoefficient();

        Console.Write("Enter the value of x: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Fraction value at x = " + x + ": " + fraction.CalculateFractionValue(x));

        ThreeDimensionalFraction threeDimensionalFraction = new ThreeDimensionalFraction(3, 4, 5);
        threeDimensionalFraction.PrintCoefficient();

        Console.Write("Enter the value of x: ");
        x = double.Parse(Console.ReadLine());

        Console.WriteLine("Three-dimensional fraction value at x = " + x + ": " + threeDimensionalFraction.CalculateFractionValue(x));
    }
}