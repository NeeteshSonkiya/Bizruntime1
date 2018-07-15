using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class Array3D
    {
        static int[,] x = { { 1, 3, 5 }, { 2, 4, 6 }, { 7, 8, 9 } };
        static void Main(string[] args)
        {
            Console.WriteLine("Printing 2D Array..");
            Array3D a2 = new Array3D();
            // a2.printArray(x);
            a2.printArray2();
            Console.Read();
        }
        public void printArray(int[,] arr)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(arr[r,c]);
                }
                Console.WriteLine();
            }
        }
        public void printArray2()
        {
            int[,] arr = new int[3, 4];
            Console.WriteLine("Enter array element");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = int.Parse(Console.ReadLine());
                }
                
            }
            Console.WriteLine();
            Console.WriteLine("Printing Array element....");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
