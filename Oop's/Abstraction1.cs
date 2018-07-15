using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //abstraction with abstract class
{
    public abstract class Shape
    {
        public abstract void draw1();
    }
    public class Tringle : Shape
    {
        public override void draw1()
        {
            Console.WriteLine("rectangle drawing......");
        }
    }
    public class Circle : Shape
    {
        public override void draw1()
        {
            Console.WriteLine("Circle drawing...........");
        }
    }
    class Abstraction1
    {
        static void Main(string[] args)
        {
            Shape s;
            s = new Tringle();
            s.draw1();
            s = new Circle();
            s.draw1();
            Console.ReadKey();
        }
    }
}