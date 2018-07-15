using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SortedListGenericsEx
    {
        static void Main(string[] args)
        {
            SortedList<int, string> slg = new SortedList<int, string>();
            slg.Add(1, "manager");
            slg.Add(53, "employee");
            slg.Add(3, "tester");
            slg.Add(44, "devloper");
            slg.Add(15, "techS");
            slg.Add(6, "welcome");
            foreach (KeyValuePair <int, string> k in slg)
            {
                Console.WriteLine(k.Key + " . " + k.Value);
            }
            Console.Read();
        }
    }
}
