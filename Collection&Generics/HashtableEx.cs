using System;
using System.Collections;
using System.Text;

namespace Collection
{
    class HashtableEx
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "hello");
            ht.Add(2, "gd day");
            ht.Add(3, "hello guys");
            ht.Add(6, 3223);
            foreach(DictionaryEntry v in ht)
            {
                Console.WriteLine(v.Key + ", " + v.Value);
            }
            Console.WriteLine("=====================");
            for (int i = 0; i < ht.Count; i++)
            {
                Console.WriteLine(ht[i]);
            }
            Console.Read();
        }
    }
}
