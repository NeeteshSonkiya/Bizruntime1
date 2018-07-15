using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class SortedSetGenericsEx
    {
        static void Main(string[] args)
        {
            SortedSet<string> ss = new SortedSet<string>();
            ss.Add("jack");
            ss.Add("cloe");
            ss.Add("jane");
            ss.Add("jessica");
            ss.Add("sohny");
            foreach(string s in ss)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
