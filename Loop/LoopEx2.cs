using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx2
    {
        static void Main(String[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
