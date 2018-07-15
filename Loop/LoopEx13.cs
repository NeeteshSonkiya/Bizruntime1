using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx13
    {
        static void Main(String[] args)
        {
            string str = "Hello guys welcome to bangalore";
            foreach (char c in str)
            {
                Console.WriteLine(c);
            }
            Console.ReadKey();
        }
    }
}
