namespace MatrixApp
{
    class Matrix3D : Matrix2D
    {
        private int[,,] matrix;

        public Matrix3D(int rows, int cols, int depth) : base(rows, cols)
        {
            matrix = new int[rows, cols, depth];
        }

        public new void Set()
        {
            Console.WriteLine("Введiть елементи тривимiрної матрицi:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        Console.Write($"matrix[{i},{j},{k}] = ");
                        matrix[i, j, k] = int.Parse(Console.ReadLine());
                    }
                }
            }
        }
        public new void Random()
        {
            Random random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        matrix[i, j, k] = random.Next(-100, 101);
                        Console.Write($"A[{i},{j},{k}] = {matrix[i, j, k]}\n");
                    }
                }
            }
        }
        public new int Min()
        {
            int minElement = matrix[0, 0, 0];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    for (int k = 0; k < matrix.GetLength(2); k++)
                    {
                        if (matrix[i, j, k] < minElement)
                        {
                            minElement = matrix[i, j, k];
                        }
                    }
                }
            }
            return minElement;
        }
    }
}