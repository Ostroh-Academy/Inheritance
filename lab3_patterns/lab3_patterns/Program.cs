using System;

public class TwoDimensionalMatrix
{
    protected int[,] matrix = new int[3, 3];
    public void InputElements()
    {
        Console.WriteLine("Enter elements for 3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Element [{i},{j}]: ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
    }
    public void RandomizeElements()
    {
        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                matrix[i, j] = rand.Next(0, 100);
            }
        }
    }
    public int FindMinElement()
    {
        int min = matrix[0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                if (matrix[i, j] < min)
                {
                    min = matrix[i, j];
                }
            }
        }
        return min;
    }
    public void PrintMatrix()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
public class ThreeDimensionalMatrix : TwoDimensionalMatrix
{
    private int[,,] matrix3D = new int[3, 3, 3];
    public void InputElements3D()
    {
        Console.WriteLine("Enter elements for 3x3x3 matrix:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write($"Element [{i},{j},{k}]: ");
                    matrix3D[i, j, k] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
    public void RandomizeElements3D()
    {
        Random rand = new Random();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matrix3D[i, j, k] = rand.Next(0, 100);
                }
            }
        }
    }

    public int FindMinElement3D()
    {
        int min = matrix3D[0, 0, 0];
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    if (matrix3D[i, j, k] < min)
                    {
                        min = matrix3D[i, j, k];
                    }
                }
            }
        }
        return min;
    }
    public void PrintMatrix3D()
    {
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.Write(matrix3D[i, j, k] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
class Program
{
    static void Main()
    {
        TwoDimensionalMatrix matrix2D = new TwoDimensionalMatrix();
        matrix2D.RandomizeElements();
        Console.WriteLine("2D Matrix:");
        matrix2D.PrintMatrix();
        int min2D = matrix2D.FindMinElement();
        Console.WriteLine($"Minimum element in 2D matrix: {min2D}");

        ThreeDimensionalMatrix matrix3D = new ThreeDimensionalMatrix();
        matrix3D.RandomizeElements3D();
        Console.WriteLine("3D Matrix:");
        matrix3D.PrintMatrix3D();
        int min3D = matrix3D.FindMinElement3D();
        Console.WriteLine($"Minimum element in 3D matrix: {min3D}");
    }
}