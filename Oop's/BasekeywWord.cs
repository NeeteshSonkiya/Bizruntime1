using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Shape
    {
        public Shape()
        {
            Console.WriteLine("Shape Constructor");
        }
        public virtual void draw()
        {
            Console.WriteLine("drawing..........");
        }
    }
    public class Square:Shape
    {
        public Square()
            :base()
        {
            Console.WriteLine("Square Constructor");
        }
        public override void draw()
        {
            Console.WriteLine("Square drawing........");
        }
    }
    public class Circle:Shape
    {
        public Circle()
            :base()
        {
            Console.WriteLine("Circle Constructor");
        }
        public override void draw()
        {
            Console.WriteLine("Circle drawing........");
        }
    }
    class BasekeywWord
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Shape();
            s.draw();
            s = new Square();
            s.draw();
            s = new Circle();
            s.draw();
            Console.ReadKey();

        }
    }
}
