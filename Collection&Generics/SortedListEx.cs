using System;
using System.Collections;
using System.Text;

namespace Collection
{
    class ShortedListEx
    {
        static void Main(string[] args)
        {
            SortedList sl = new SortedList();
            sl.Add(1, "hello");
            sl.Add(20, "test");
            sl.Add(30, "C3");
            sl.Add(4, "hell");
            foreach ( DictionaryEntry l in sl)
            {
                Console.WriteLine(l.Key + ", " + l.Value);
            }
            Console.WriteLine("----------------");
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine(sl.GetKey(i) + ". "  + sl.GetByIndex(i));
            }
            Console.Read();
        }
    }
}
