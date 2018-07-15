using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Generics2 <T>
    {
        public void display(T a, T b)
        {
            Console.WriteLine(a + ", " + b);
        }
    }
    class GenericsEx2
    {
        static void Main(string[] args)
        {
            Generics2<string> g2 = new Generics2 <string>();
            Generics2<int> g21 = new Generics2 <int>();
            g2.display("welcome" , "guys");
            g21.display(10, 20);
            Console.Read();
        }   
    }
}
