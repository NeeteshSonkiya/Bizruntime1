//Factorial number
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx6
    {
        static void Main(String[] Main)
        {
            int num = int.Parse(Console.ReadLine());
            int result = 1;
            while (num != 0) 
            {
                result *= num;
                num--;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
