using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory3
{
    public class Rectangle
    {
        protected double a1;
        protected double a2;
        protected double b1;
        protected double b2;

        public Rectangle(double a1, double a2, double b1, double b2)
        {
            this.a1 = a1;
            this.a2 = a2;
            this.b1 = b1;
            this.b2 = b2;
        }

        public override string ToString()
        {
            return $"a1= {a1} \n" +
                $"a2 = {a2} \n" +
                $"b1 = {b1} \n" +
                $"b2 = {b2} \n";
        }

        public virtual bool IsPointInside(double [] arr)
        {
            if (arr[0] >= b1 && arr[0] <= a1 && arr[1] >= b2 && arr[1] <= a2)
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
