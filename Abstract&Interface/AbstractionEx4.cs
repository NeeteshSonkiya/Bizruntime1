using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    abstract class Shape
    {
        public abstract void drawing();
    }
    class Rectangle : Shape
    {
        public override void drawing()
        {
            Console.WriteLine("Drawing rectangle .....");
        }
    }
    class Circle : Shape
    {
        public override void drawing()
        {
            Console.WriteLine("Drawing circle .....");
        }
    }
    class AbstractionEx4
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Rectangle();
            s.drawing();
            Console.WriteLine();
            s = new Circle();
            s.drawing();
            Console.Read();
        }
    }
}
