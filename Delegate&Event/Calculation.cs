using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Calculation
    {
        public delegate int Calculator(int n);
        public static int number = 100;

        public int add(int n)
        {
            number = number + n;
            return number;
        }
        public int sub(int n)
        {
            number = number - n;
            return number;
        }
        public int mul(int n)
        {
            number = number * n;
            return number;
        }

        public static int getNumber()
        {
            return number;
        }
        static void Main(string[] args)
        {
            Calculation td = new Calculation();
            Calculation.Calculator c1 = new Calculation.Calculator(td.add);
            Calculation.Calculator c2 = new Calculation.Calculator(td.sub);
            Calculation.Calculator c3 = new Calculation.Calculator(td.mul);

            c1(10);
            Console.WriteLine("Number after addition : " + getNumber());
            c2(10);
            Console.WriteLine("Number after substraction : " + getNumber());
            c3(10);
            Console.WriteLine("Number after multipication : " + getNumber());
            Console.Read();
        }
    }
}
