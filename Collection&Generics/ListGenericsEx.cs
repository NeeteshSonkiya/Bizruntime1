using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ListGenericsEx
    {
        static void Main(string[] args)
        {
            List <string> l = new List <string>();
            l.Add("john");
            l.Add("johny");
            l.Add("joe");
            l.Add(null);
            l.Add("jess");
            l.Add("jorden");
            foreach (string s in l)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("===========================");
            Console.WriteLine(l.BinarySearch("joe"));
            l.Remove("jane");
            l.Sort();
            l.Insert(3, "joe");
            for (int i = 0; i < l.Count; i++)
            {
                Console.WriteLine(l[i]);
            }

            Console.Read();
        }
    }
}
