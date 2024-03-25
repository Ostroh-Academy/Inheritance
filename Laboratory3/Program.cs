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

            Console.WriteLine("Checking for rectangle:");
            if (rectangle.IsPointInside(2, 3))
            {
                Console.WriteLine("This point lies on this rectangle");
            }
            else { Console.WriteLine("This point not lies on this rectangle"); }

            if (rectangle.IsPointInside(1, 5))
            {
                Console.WriteLine("This point lies on this rectangle");
            }
            else { Console.WriteLine("This point not lies on this rectangle"); }

            Console.WriteLine("\n Checking for parallelepiped:");
            Console.WriteLine(parallelepiped.IsPointInside(2, 3, 4)); 
            Console.WriteLine(parallelepiped.IsPointInside(6, 6, 6)); 
        }
    }
}
