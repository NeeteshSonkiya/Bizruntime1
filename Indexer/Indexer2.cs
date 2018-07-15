using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer
{
    class Test
    {
        private string[] str = new string[10];
        public string this[int index]
        {
            get
            {
                if (index < 0 && index >= str.Length)
                    throw new IndexOutOfRangeException("can not store more then 10 element");
                return str[index];
            }
            set
            {
                if (index < 0 && index >= str.Length)
                    throw new IndexOutOfRangeException("can not store more then 10 element");
                str[index] = value;
            }
        }
        class Indexer2
        {
            static void Main(string[] args)
            {
                Test t = new Test();
                t[0] = "hello";
                t[1] = "hi";
                t[2] = "good evening";
                t[3] = "welocome to biz";
                Console.WriteLine(t[0]);
                Console.WriteLine(t[2]);
                Console.WriteLine(t[3]);
                Console.WriteLine(t[4]);
                Console.ReadLine();
            }
        }
    }
}
