using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public struct Rectangle
    {
        public int hight;
        public int breadth;
        public Rectangle(int h, int b)
        {
            this.hight = h;
            this.breadth = b;
        }
    }
    static class StructEx
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();
            Console.WriteLine("height = " + r.hight + " & breadth = "  + r.breadth);
            r.hight = 100;
            r.breadth = 10;
            Console.WriteLine("hight = " + r.hight + " & breadth = " + r.breadth);
            Console.ReadKey();
        }
    }
}
