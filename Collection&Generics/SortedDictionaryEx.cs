using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SortedDictionaryEx
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, string> sd = new SortedDictionary<string, string>();
            sd.Add("1", "all my life");
            sd.Add("a", "ashes");
            sd.Add("hello", "born ready");
            sd.Add("4", "mercy");
            sd.Add("8", "no limits");
            foreach(KeyValuePair <string, string> s in sd)
            {
                Console.WriteLine(s.Key + " , " + s.Value);
            }
            Console.Read();
        }
    }
}
