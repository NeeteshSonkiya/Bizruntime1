using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    interface IDraw
    {
        void drawing1();
    }
    interface IShape : IDraw
    {
        void drawing2();
    }
    class rectangle : IShape
    {
        public void drawing1()
        {
            Console.WriteLine("drawing.......");
        }
        public void drawing2()
        {
            Console.WriteLine("Shape drawing......");
        }
        public void drawing3()
        {
            Console.WriteLine("rectangle drawing.....");
        }
    }
    class MultilevelInterface
    {
        static void Main(string[] args)
        {
            IDraw id = new rectangle();
            id.drawing1();
            Console.WriteLine();
            IShape isp = new rectangle();
            isp.drawing2();
            Console.WriteLine();
            rectangle rec = new rectangle();
            rec.drawing3();
            Console.Read();
        }
    }
}
