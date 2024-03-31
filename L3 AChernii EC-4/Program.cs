using System;

namespace MatrixApp /*Варіант 6*/
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Matrix2D matrix2D = new Matrix2D(3, 3);

            Matrix3D matrix3D = new Matrix3D(3, 3, 3);

            Console.Write($"Оберiть метод задання елементiв матриць:\n1 - задавати значення\n2 - рандомне заповнення\nМетод:\t");
            int elemR = int.Parse(Console.ReadLine());
            if(elemR == 1)
            {
                matrix2D.Set();
                matrix3D.Set();
            } else
            {
                Console.WriteLine($"Двовимрiна матриця:");
                matrix2D.Random();

                Console.WriteLine($"Тривимрiна матриця:");
                matrix3D.Random();
            }
            
            int minElement2D = matrix2D.Min();
            Console.WriteLine($"Мiнiмальний елемент двовимiрної матрицi: {minElement2D}");            
            int minElement3D = matrix3D.Min();
            Console.WriteLine($"Мiнiмальний елемент тривимiрної матрицi: {minElement3D}");
        }
    }
}