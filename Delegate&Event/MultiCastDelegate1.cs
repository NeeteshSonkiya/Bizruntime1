using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public delegate void rec(double w, double b);

    class MultiCastDelegate1
    {
        public static void RectangleArea(double w, double b)
        {
            Console.WriteLine("Rectangle area is : " + (w * b));
        }
        public static void RectanglePerimeter(double w, double b)
        {
            Console.WriteLine("Rectangle area is : " + 2 *(w + b));
        }
        static void Main(string[] args)
        {
            rec del = new rec(RectangleArea);
            del += new rec(RectanglePerimeter);

            del(5.5, 4.5);
            Console.Read();
        }
    }
}
