using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1   // method with differ return type, and specifier
{
    class Method2
    {
        private int method()
        {
            Console.WriteLine("private int method");
            return 10;
        }
        protected double method1()
        {
            Console.WriteLine("protected double method1");
            return 11.1;
        }
        public string name()
        {
            Console.WriteLine("string method");
            return "Welcome";
        }
        static void Main(string[] args)
        {
            Method2 m = new Method2();
            int i = m.method();
            double d = m.method1();
            string name = m.name();
            Console.WriteLine(" int i = "  + i);
            Console.WriteLine(" double d = " + d);
            Console.WriteLine(" string name = " + name);
            Console.Read();
        }
    }
}
