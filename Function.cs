using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_P
{
	public class Function
	{
		private double a1, a0, b1, b0;
		public Function(double a1, double a0, double b1, double b0)
		{
			this.a1 = a1;
			this.a0 = a0;
			this.b1 = b1;
			this.b0 = b0;
		}
		public void Coefficients(double a1, double a0, double b1, double b0)
		{
			this.a1 = a1;
			this.a0 = a0;
			this.b1 = b1;
			this.b0 = b0;
		}
		public void PrintCoefficients()
		{
			Console.WriteLine($"a1 = {a1}, a0 = {a0}, b1 = {b1}, b0 = {b0}");
		}
		public double Calculation(double x)
		{
			return (a1 * x + a0) / (b1 * x + b0);
		}
	}

}



