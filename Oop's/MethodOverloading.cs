using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4   //Method overloading
{
    class MethodOverloading
    {
        public int add(int a, int b)
        {
            Console.WriteLine(a + b);
            return a + b;
        }
        public double add(int a, float b, double c)
        {
            Console.WriteLine(a + b + c);
            return a + b + c;
        }
        public void add(int a, double b)
        {
            double result = a + b;
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            MethodOverloading c8 = new MethodOverloading();
            c8.add(5, 3);
            c8.add(5, 5.5f, 543.3);
            c8.add(94, 43.3);
            Console.ReadKey();
        }
    }
}
