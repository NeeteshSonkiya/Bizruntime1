using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class SumOfElement
    {
        int[] x = new[] { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
        public void sum()
        {
            int sum = 0;
            Console.WriteLine("Print Array...");
            foreach (int s in x)
            {
                Console.Write(s + ",");
                sum += s;
            }
            Console.WriteLine();
            Console.WriteLine("----------------");
            Console.WriteLine();
            Console.WriteLine("Sum of the Element of an array is : " + sum);
        }
    }
    class CopyArray
    {
        public void copyArray()
        {
            string[] str = new string[7] { "hello", "hi", "hey", "hiiii ", "heyyyy", "helloooo", "hello guys" };
            string[] str1 = new string[7];
            Array.Copy(str, str1, str.Length);
            foreach(string s in str1)
            {
                Console.Write(s + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("===========================================");
            Console.WriteLine();
        }
        
    }
    class SearchElement
    {
        public void searchElement()
        {
            int[] x = new int[] { 12, 23, 2, 34, 34, 34, 45, 23, 12, 54, 23, 65, 54 };
            int j = 0;
            Console.WriteLine("Enter the search element.....");
            int element = int.Parse(Console.ReadLine());
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == element)
                {
                    Console.WriteLine("Element {0} found in index {1}", x[i], i);
                    j++;
                    break;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Element not found");
            }
        }
    }
    class ArrayExercise
    {
        static void Main(string[] args)
        {
            SumOfElement s = new SumOfElement();
           // s.sum();
            Console.WriteLine("==========================================");
            CopyArray cp = new CopyArray();
            // cp.copyArray();
            SearchElement se = new SearchElement();
            se.searchElement();
            Console.Read();
        }
    }
    
}
