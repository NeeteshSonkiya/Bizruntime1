using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Test
    {
        public virtual void testMethod()
        {
            Console.WriteLine("virtual test method");
        }
    }
    class MethodOverriding : Test
    {
        public override void testMethod()
        {
            Console.WriteLine("override test method");
        }
        static void Main(string[] args)
        {
            // MethodOverriding m = new MethodOverriding();
            //m.testMethod();
            Test t = new MethodOverriding();
            t.testMethod();
            Console.WriteLine("Main method complete");
            Console.Read();
        }
    }
}
