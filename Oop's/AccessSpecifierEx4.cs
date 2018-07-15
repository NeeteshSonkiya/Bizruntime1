using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ProtectedInaternalTest
    {
        protected internal int id = 101;
        protected internal void test()
        {
            Console.WriteLine("msg from Protected internal");
        }
    }
    class AccessSpecifierEx4
    {
        static void Main(string[] args)
        {
            ProtectedInaternalTest pit = new ProtectedInaternalTest();
            pit.test();
            Console.WriteLine(pit.id);
            Console.ReadKey();
        }
    }
}
