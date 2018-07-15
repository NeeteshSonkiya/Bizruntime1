using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class PassByReferance
    {
        public void show(ref int val)
        {
            val += val;
            Console.WriteLine("Value inside the show() : " + val);
        }
        static void Main(string[] args)
        {
            int val = 10;
            Console.WriteLine("value inside the main method : " + val);
            PassByReferance cbr = new PassByReferance();
            cbr.show(ref val);
            Console.WriteLine("after calling show method : " + val);
            Console.ReadKey();
        }
    }
}
