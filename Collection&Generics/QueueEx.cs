using System;
using System.Collections;
using System.Text;

namespace Collection
{
    class QueueEx
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue("hello");
            q.Enqueue("test");
            q.Enqueue("string");
            foreach(var v in q)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("===========================");
            for(int i =0; i < q.Count; i++)
            {
                Console.WriteLine(q.Dequeue());
            }
            Console.Read();
        }
    }
}
