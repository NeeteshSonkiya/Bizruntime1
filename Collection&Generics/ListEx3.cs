using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ListEx3 
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>() { 10, 20, 30, 40, 50, 60 };
            IEnumerable<int> item= (IEnumerable<int>)l;
            foreach(int i in item)
            {
                Console.Write(i + ", ");
            }
            Console.WriteLine();
            IEnumerator<int> item1 = l.GetEnumerator();
            while (item1.MoveNext())
            {
                Console.WriteLine(item1.Current.ToString());
            }
            Console.Read();
        }
    }
}
