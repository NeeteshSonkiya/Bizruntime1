using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class OutKeyword
    {
        public void test(out int val)
        {
            int s = 50;
            val = s;
            val += val;
            Console.WriteLine("value in test : " + val);
        }
        static void Main(string[] args)
        {
            int val;
           // Console.WriteLine("value = " + val);
            OutKeyword cto = new OutKeyword();
            cto.test(out val);
            Console.WriteLine("value after calling test : " + val);
            Console.Read();
        }
    }
}
