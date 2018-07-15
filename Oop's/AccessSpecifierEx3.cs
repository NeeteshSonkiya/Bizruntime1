using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //Internal specifier-> we can access internal member within the file in same assembly
{
    class InternalTest
    {
        internal string name = "rohan";
        internal void test()
        {
            Console.WriteLine("welcome to test...");
        }
    }
    class AccessSpecifierEx3
    {
        static void Main(string[] args)
        {
            InternalTest it = new InternalTest();
            it.test();
            Console.WriteLine("My name is  " + it.name);
            Console.ReadKey();
        }
    }
}
