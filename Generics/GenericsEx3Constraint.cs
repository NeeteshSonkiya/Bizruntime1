using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Generics3 < T > where T : class
    {
        public void display(T a, T b)
        {
            Console.WriteLine(a + ", " + b);
        }
    }
    class Generics31 <S> where S : struct
    {
        public void display(S i, S j)
        {
            Console.WriteLine(i + ", " + j);
        }
    }
    class GenericsEx3Constraint
    {
        static void Main(string[] args)
        {
            Generics3 <string> g3 = new Generics3 <string> ();
            g3.display("hello", "guys");
            Generics31<int> g31 = new Generics31<int>();
            g31.display(21, 2121);
            Generics31<double> g32 = new Generics31<double>();
            g32.display(11.1, 22.2);

            Console.Read();
        }
    }
}
