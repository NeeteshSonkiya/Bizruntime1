using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx10
    {
        static void Main(String[] args)
        {
            int n = 19;
            for (int i = 1; i <= n; i++)
            {
                if (i < 10)
                    continue;
                Console.Write(i + ",");
            }
            Console.ReadKey();
        }
    }
}
