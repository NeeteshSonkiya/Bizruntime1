using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    abstract class AbsBase
    {
        public abstract int mul(int x, int y);
        public abstract int div(int x, int y);
    }
    class AbsDrive : AbsBase
    {
        public override int mul(int x, int y)
        {
            return x * y;
        }
        public override int div(int x, int y)
        {
            return x / y;
        }
    }
    class AbstractionEx2
    {
        static void Main(string[] args)
        {
            AbsDrive ad1 = new AbsDrive();
            AbsBase ab = new AbsDrive();
            //int result = ad1.mul(100, 10);
            int result = ad1.div(100, 10);
            Console.WriteLine("The result is : " +  result);
            Console.Read();
        }
    }
}
