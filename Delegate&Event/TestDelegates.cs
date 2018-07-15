using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class TestDelegates
    {
        //Declation
        public delegate void FirstDelegate();

        public static void Method1()
        {
            Console.WriteLine("Printing method1....");
        }
        public static void Method2()
        {
            Console.WriteLine("Printing method2....");
        }
        public static void Method3()
        {
            Console.WriteLine("Printing method3....");
        }

        static void Main(string[] args)
        {
            //Initialization
            FirstDelegate f1 = new FirstDelegate(Method1);
            FirstDelegate f2 = new FirstDelegate(Method2);
            FirstDelegate f3 = new FirstDelegate(Method3);
            //Invocation
            f1();
            f2();
            f3();
            Console.Read();
        }
    }
}
