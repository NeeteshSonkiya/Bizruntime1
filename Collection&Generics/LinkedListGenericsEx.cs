using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class LinkedListGenericsEx
    {
        static void Main(string[] args)
        {
            LinkedList<string> ll = new LinkedList<string>();
            ll.AddFirst("we are hero in the dark side");
            ll.AddLast("i like trouble");
            ll.AddFirst("i dont believe in satan bcoz i done rise the hell");
            ll.AddLast("someday someday we are gonna rule the world");
            ll.AddLast("playlist");
            LinkedListNode<string> node = ll.Find("playlist");
            ll.AddBefore(node, "zadye wolf");
            ll.AddAfter(node, "Lucifer Morning star");
            foreach(string s in ll)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
