using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Method3       //static and non static method
    {
        public void test1()
        {
            Console.WriteLine("non static method");
        }
        public static void test2()
        {
            Console.WriteLine("static method");
        }
        static void Main(string[] args)
        {
            Method3 m = new Method3();
            m.test1();
            //m.test2(); we can not access static member through instance
            test2();
            Console.Read();
        }
    }
}
