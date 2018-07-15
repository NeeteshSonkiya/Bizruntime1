using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Generics4 <S>
    {
        public void add(S a, S b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            //Console.WriteLine(a + b);
            Console.WriteLine(d1 + d2);
            Console.WriteLine("=========================");
        }
        public void sub(S a, S b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 - d2);
            Console.WriteLine("=========================");
        }
        public void multi(S a, S b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 * d2);
            Console.WriteLine("=========================");
        }
        public void div(S a, S b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine(d1 / d2);
            Console.WriteLine("=========================");
        }
    }
    class GenericsEx4
    {
        static void Main(string[] args)
        {
            Generics4 <int> g4 = new Generics4<int>();
            Generics4<float> g41 = new Generics4<float>();
            Generics4<double> g42 = new Generics4<double>();
            g4.add(10, 20);g4.sub(20, 10);g4.multi(10, 20);g4.div(100, 20);
            Console.WriteLine("--------**------------***---------------**-------");
            g41.add(4.7f, 9.3f); g41.sub(11.4f, 5.2f); g41.multi(4.3f, 5.4f); g41.div(10.14f, 5.5f);
            Console.WriteLine("--------**------------***---------------**-------");
            g42.add(5.5, 9.5); g42.sub(50.4, 4.5); g42.multi(84.4, 7.9); g42.div(98.3, 8.3);
            Console.Read();
        }
    }
}
