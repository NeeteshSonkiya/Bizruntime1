using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class IfelseEx5
    {
        static void Main(String[] args)
        {
            var num = 10;
            bool flag;
            flag = num % 2 == 0 ? true : false;
            Console.WriteLine(flag);
            Console.ReadKey();
        }
    }
}
