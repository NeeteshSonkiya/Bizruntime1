using System;
using System.Collections;
using System.Text;

namespace Collection
{
    class StackEx
    {
        static void Main(string[] args)
        {
            Stack s = new Stack();
            s.Push(102);
            s.Push("hello");
            s.Push(true);
            foreach(var d in s)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());
            Console.Read();
        }
    }
}
