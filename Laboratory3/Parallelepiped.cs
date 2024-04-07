using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory3
{
    public class Parallelepiped : Rectangle
    {
        private double a3;
        private double b3;

        public Parallelepiped(double b1 = 1, double b2 = 2, double a1 = 1, double a2 = 2, double a3 = 3, double b3 = 3)
            : base(b1, b2, a1, a2)
        {
            this.a3 = a3;
            this.b3 = b3;
        }

        public override string ToString()
        {
            return base.ToString() +
                $"a3 = {a3} \n" +
                $"b3 = {b3} \n";
        }

        public override bool IsPointInside(double[] arr)
        {
            if (base.IsPointInside(arr) && arr[2] >= b3 && arr[2] <= a3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
