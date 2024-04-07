namespace Laboratory3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(1, 1, 5, 5);
            Console.WriteLine("Coeficients of rectangle: \n"+rectangle);
            
            Parallelepiped parallelepiped = new Parallelepiped(1, 1, 1, 2, 3, 2);
            Console.WriteLine("Coeficients of parallelepiped: \n" + parallelepiped);

            double[] rectanglePoints = new double[] {1,2};
            double[] ParallelepipedPoints = new double[] { 1, 2, 2 };

            Console.WriteLine("Checking for rectangle:");
            if (rectangle.IsPointInside(rectanglePoints))
            {
                Console.WriteLine("This point lies on this rectangle");
            }
            else { Console.WriteLine("This point not lies on this rectangle"); }

            Console.WriteLine("\n Checking for parallelepiped:");
            if (parallelepiped.IsPointInside(ParallelepipedPoints))
            {
                Console.WriteLine("This point lies on this Parallelepiped");
            }
            else { Console.WriteLine("This point not lies on this Parallelepiped"); }
        }
    }
}
