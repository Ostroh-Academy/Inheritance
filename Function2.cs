using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab_3_P
{
	public class Function2 : Function
	{
		private double a2, a1, a0, b2, b1, b0;
		public Function2(double a2, double a1, double a0, double b2, double b1, double b0)
			: base(a1, a0, b1, b0)
		{
			this.a2 = a2;
			this.a1 = a1;
			this.a0 = a0;
			this.b2 = b2;
			this.b1 = b1;
			this.b0 = b0;
		}
		public new void SetCoefficients(double a2, double a1, double a0, double b2, double b1, double b0)
		{
			base.Coefficients(a1, a0, b1, b0);
			this.a2 = a2;
			this.a1 = a1;
			this.a0 = a0;
			this.b2 = b2;
			this.b1 = b1;
			this.b0 = b0;
		}
		public new void PrintCoefficients()
		{
			base.PrintCoefficients();
			Console.WriteLine($"a2 = {a2}, b2 = {b2}");
		}
		public new double Calculation(double x)
		{
			return (a2 * x * x + a1 * x + a0) / (b2 * x * x + b1 * x + b0);
		}
	}
}