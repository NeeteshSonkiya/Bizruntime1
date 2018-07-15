using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //public and private
{
    class TestAccessSpecifier
    {
        private int id = 101;
        public string name = "Lucifer Morningstar";
        public void hello()
        {
            Console.WriteLine("from Test");
        }
    }
    class AccessSpecifierEx2
    {
        static void Main(string[] args)
        {
            TestAccessSpecifier t = new TestAccessSpecifier();
            //Console.WriteLine("id = " + t.id);        //private member are resitricted to another class
            Console.WriteLine("name = " + t.name);
            t.hello();
            Console.ReadKey();
        }
    }
}
