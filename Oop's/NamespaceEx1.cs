using System;
using System.Collections.Generic;
using System.Text;
using First;
using Second;
namespace First
{
    class Test
    {
        public void test()
        {
            Console.WriteLine("from test First");
        }
    }
}
namespace Second
{
    class Test1
    {
        public void test1()
        {
            Console.WriteLine("from test Second");
        }
    }
}
namespace ConsoleApp4
{
    class NamespaceEx1
    {
        static void Main(string[] args)
        {
            Test t1 = new Test();
            Test1 t2 = new Test1();
            t1.test();
            t2.test1();
            Console.ReadKey();
        }
    }
}
