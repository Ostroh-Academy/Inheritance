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

        public string IsPointInside(double x1, double x2, double x3)
        {
            if (base.IsPointInside(x1, x2) && x3 >= b3 && x3 <= a3)
            {
                return $"This point ({x1}, {x2}, {x3}) lies on this parallelepiped";
            }
            else
            {
                return $"This point ({x1} , {x2} , {x3}) not lies on this parallelepiped ";
            }
        }

    }
}
