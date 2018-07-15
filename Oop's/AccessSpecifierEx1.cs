using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //protect example
{
    class ProtectedTest
    {
        protected int id = 10;
        protected void hello()
        {
            Console.WriteLine("Protected test......");
        }
    }
    class AccessSpecifierEx1: ProtectedTest    // we can inherite protected member into another class but we cann't use without inheriting
    {
        static void Main(string[] args)
        {
            AccessSpecifierEx1 p = new AccessSpecifierEx1();
            p.hello();
            Console.WriteLine("id = " + p.id);
            Console.ReadKey();
        }
    }
}
