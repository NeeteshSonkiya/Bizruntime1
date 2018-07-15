using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //Multi level inheritance
{
    public class Test
    {
        public void test()
        {
            Console.WriteLine("From Test");
        }
    }
    public class Test1:Test
    {
        public void test1()
        {
            Console.WriteLine("From Test1");
        }
    }
    public class Test2:Test1
    {
        public void test2()
        {
            Console.WriteLine("From Test2");
        }
    }
    public class Test3:Test2
    {
        public void test3()
        {
            Console.WriteLine("From Test3");
        }
    }
    class Inheritance2
    {
        static void Main(string[] args)
        {
            Test3 t = new Test3();
            t.test();
            t.test1();
            t.test2();
            t.test3();
            Console.ReadKey();
        }
    }
}
