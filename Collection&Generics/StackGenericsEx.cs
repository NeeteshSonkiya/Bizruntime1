using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class StackGenericsEx
    {
        static void Main(string[] args)
        {
            Stack <int> sta = new Stack<int>();
            sta.Push(10);
            sta.Push(20);
            sta.Push(30);
            sta.Push(40);
            sta.Push(50);
            foreach (int n in sta)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(sta.Peek());
            Console.WriteLine(sta.Pop());
            Console.Read();
        }
    }
}
