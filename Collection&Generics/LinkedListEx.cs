using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Collection
{
    class LinkedListEx
    {
        static void Main(string[] args)
        {
            LinkedList<int> ll = new LinkedList<int>();
            ll.AddFirst(10);
            ll.AddLast(20);
            ll.AddLast(30);
            ll.AddLast(40);
            ll.AddLast(50);
            Console.WriteLine("Before Adding elemet...");
            foreach (int i in ll)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");
            Console.WriteLine();
            LinkedListNode<int> node = ll.Find(30);
            ll.AddAfter(node, 11);
            Console.WriteLine("Adding element after 30 ...");
            foreach(int i in ll)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
