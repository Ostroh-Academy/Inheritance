using Lab_3_P;

class Program
{
	static void Main(string[] args)
	{
		Function fractionalLinearFun = new Function(2, 3, 4, 5);
		Function2 fractionalFun = new Function2(1, 2, 3, 4, 5, 6);

		Console.WriteLine("Fractional Linear Function coefficients:");
		fractionalLinearFun.PrintCoefficients();
		Console.WriteLine("Fractional Function coefficients:");
		fractionalFun.PrintCoefficients();

		double x = 2.5;
		Console.WriteLine($"Value of Fractional Linear Function at x = {x}: {fractionalLinearFun.Calculation(x)}");
		Console.WriteLine($"Value of Fractional Function at x = {x}: {fractionalFun.Calculation(x)}");
	}
}