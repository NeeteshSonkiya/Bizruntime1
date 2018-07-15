using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class ArrayClass
    {
        static void Main(string[] args)
        {
            int[] x = new int[] { 12,3432,4234,24,23,423,4,23 };
            Console.WriteLine("Length is : " + x.Length);
            Console.WriteLine("Rank is : " + x.Rank);
            Array.Sort(x);
            Array.Reverse(x);
       
            for (int i = 0; i < x.Length; i++)
            {
               Console.Write(x[i]+ ", ");
            }
            Console.ReadLine();
        }
    }
}
