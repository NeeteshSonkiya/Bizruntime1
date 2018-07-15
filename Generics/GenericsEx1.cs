using System;

namespace Generics
{
    class Generics1
    {
        public void generics<T>(T a, T b)
        {
            Console.WriteLine(a + " , " + b);
        }
    }
    class GenericsEx1
    {
        static void Main(string[] args)
        {
            Generics1 g1 = new Generics1();
            g1.generics(10, 20);
            g1.generics<float>(1.1f,2.1f);
            g1.generics(12.1, 32.2);
            g1.generics<string>("hello", "Welcome");
            Console.Read();
        }
    }
}
