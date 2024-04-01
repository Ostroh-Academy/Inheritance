using OneVector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListVector
{
    public class Matrix : Vector
    {
        public Vector[] vectors { get; private set; }
        public Matrix(Vector[] vectors)
        {
            vectors = new Vector[4];
        }
        public Matrix()
        {
            vectors = new Vector[4];
            for (int i = 0; i < vectors.Length; i++)
            {
                Vector vector = new Vector();
                vectors[i]=vector;
            }
        }
        public override void ShowArray()
        {
            Console.WriteLine("Матриця 4х4 :");
            for (int i = 0;i < vectors.Length;i++)
            {
                Console.WriteLine(vectors[i].ToString());
            }
        }
        public override int MaxfromArray()
        {
            int max = vectors[0].MaxfromArray();
            for (int i = 1; i < vectors.Length; i++)
            {
                int currentMax = vectors[i].MaxfromArray();
                if (currentMax > max)
                    max= currentMax;
            }
            return max;
        }
        public override void MaxfromArrayShow()
        {
            int max = MaxfromArray();
            Console.WriteLine($"Максимальне значення в матриці  :{max}");
        }


    }
}
