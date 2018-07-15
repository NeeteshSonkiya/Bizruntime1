//decimal to binary
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class LoopEx9
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the decimal number :");
            int num = int.Parse(Console.ReadLine());
            int i = 0;
            int[] a = new int[10];
            while(num > 0)
            {
                a[i] = num % 2;
                num = num / 2;
                i++;
            }
            Console.WriteLine("Converted number is");
            for (i = i-1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.ReadKey();
        }
    }
}
