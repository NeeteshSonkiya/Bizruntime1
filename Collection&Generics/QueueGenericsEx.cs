using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class QueueGenericsEx
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            foreach (int n in q)
            {
                Console.Write(n + ", ");
            }
            Console.WriteLine();
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
            Console.Read();
        }
    }
}
