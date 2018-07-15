using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class HashsetGenericsEx
    {
        static void Main(string[] args)
        {
            HashSet<int> h = new HashSet<int>() { 10, 2, 3, 32, 33, 24, 25 };
            display(h);
            Console.Read();
         }
        public static void display(HashSet<int> h1)
        {
            foreach (int n in h1)
            {
                Console.Write(n + ", ");
            }
        }
    }
}
