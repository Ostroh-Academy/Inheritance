namespace Lab_03
{
	class Quadrilateral : Triangle
	{
		protected double x4, y4;

		public Quadrilateral(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4) : base(x1, x2, x3, y1, y2, y3)
		{
			this.x1 = x1;
			this.x2 = x2;
			this.x3 = x3;
			this.x4 = x4;

			this.y1 = y1;
			this.y2 = y2;
			this.y3 = y3;
			this.y4 = y4;
		}

		public void InputCoordinates(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
		{
			base.InputCoordinates(x1, x2, x3, y1, y2, y3);

			this.x4 = x4;
			this.y4 = y4;
		}

		public void OutputCoordinates(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
		{
			base.OutputCoordinates(x1, x2, x3, y1, y2, y3);
			Console.WriteLine($"Вершина 4 = [{x4},{y4}]");
		}

		public double OutputArea(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
		{
			double a = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
			double b = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
			double c = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
			double d = Math.Sqrt(Math.Pow((x1 - x4), 2) + Math.Pow((y1 - y4), 2));

			double f = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));

			double p1 = (a + b + f) / 2;
			double p2 = (c + d + f) / 2;

			double s1 = Math.Sqrt(p1 * (p1 - a) * (p1 - b) + (p1 - f));
			double s2 = Math.Sqrt(p2 * (p2 - c) * (p2 - b) + (p2 - f));

			double s = s1 + s2;

			return s;
		}
	}
}