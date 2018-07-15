using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] x = new int[3][];
            x[0] = new int[] { 1, 2, 3};
            x[1] = new int[] { 4, 5 };
            x[2] = new int[] { 7, 8, 9, 6 };
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < x[i].Length; j++)
                {
                    Console.Write(x[i][j] + ",");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}