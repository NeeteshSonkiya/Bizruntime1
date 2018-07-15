using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ArrayAsParameter 
    {
        static int[] x = new int[] { 10, 20, 30, 2, 40, 50, 60, 70 };
        static int[] y = new int[] {11, 22, 33, 4, 4, 55, 66, 77};
        static void Main(string[] args)
        {
            Console.WriteLine("Passing the Array as Parameter...");
            Console.WriteLine();
            ArrayAsParameter ap = new ArrayAsParameter();
            ap.printArray(x);
            ap.minElement(x);
            ap.maxElement(x);
            ArrayAsParameter ap2 = new ArrayAsParameter();
            ap2.printArray(y);
            ap2.minElement(y);
            ap2.maxElement(y);
            Console.ReadLine();
        }
        public void printArray(int[] arr)
        {
            Console.WriteLine("Print Array Element.........");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + ",");
            }
            Console.WriteLine("\n");
        }
        public void minElement(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Minimum element is an array ....");
            Console.WriteLine(min);
            Console.WriteLine();
        }
        public void maxElement(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Maximum Element is an array.....");
            Console.WriteLine(max);
            Console.WriteLine();
        }
    }
}
