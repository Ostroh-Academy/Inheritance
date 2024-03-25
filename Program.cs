namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HalfPlane halfPlane = new HalfPlane(2, 3, 10);
            HalfSpace halfSpace = new HalfSpace(1, 2, 3, 20);

            Console.Write("Enter coordinates of the point separated by space: ");
            double[] point = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

            if (halfPlane.IsPointInside(point))
                Console.WriteLine("The point belongs to the half plane.");
            else
                Console.WriteLine("The point does not belong to the half plane.");

            if (halfSpace.IsPointInside(point))
                Console.WriteLine("The point belongs to the half space.");
            else
                Console.WriteLine("The point does not belong to the half space.");
        }
    }
}
