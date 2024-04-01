using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneVector
{
    public class Vector
    {
        public int[] vector { get; private set; }
        public Vector(int[] array)
        {
            vector = new int[4];
            if(array.Length!=4)
            {
                Console.WriteLine("Вектор може містити тільки 4 елементи");
                return;
            }
            
            for(int i = 0; i < array.Length; i++)
            {
                vector[i] = array[i];
            }
        }
        public Vector(int a,int b, int c, int d)
        {
            vector = new[] {a, b, c, d };
            
        }
        public Vector()
        {
            vector = new int[4];
            for(int i = 0;i<vector.Length;i++)
            {
                Console.WriteLine($"Введіть значення для {i+1} числа :");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }
        public virtual void  ShowArray()
        {
            Console.WriteLine( $"Вектор : {vector[0] } {vector[1]} {vector[2]} {vector[3]}");
        }
        public override string ToString()
        {
            return $"{vector[0]} {vector[1]} {vector[2]} {vector[3]}";
        }

        public virtual int MaxfromArray()
        {
            int max = vector[0];
            for (int i = 1; i < vector.Length; i++)
            {
                if (max < vector[i])
                    max = vector[i];
            }
            return max;
        }
        public virtual void MaxfromArrayShow()
        {
            int max = MaxfromArray();
            Console.WriteLine($"Максимальне значення в векторі :{max}");
        }
    }
}
