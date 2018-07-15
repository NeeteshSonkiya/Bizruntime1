using System;
using System.Collections;
using System.Text;

namespace Collection      //sort, reverse, clear, contains, copyTo, getRange, IndexOf,ToArray  
{
    class ArrayListEx1
    {
        public static void display(ArrayList list)
        {
            foreach (var l in list)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("------------------------------");
        }
        public void arrayMethods()
        {
            ArrayList list = new ArrayList();
            list.Add(10);
            list.Add(20);
            list.Add(30);
            list.Add(40);
            list.Add(50);
            list.Add(60);
            list.Sort();
            display(list);
            list.Reverse();
            display(list);
            Console.WriteLine(list.Contains(40));
            Console.WriteLine("---------------");
           
            Console.WriteLine("------------------");
            list.GetRange(1, 3);
            display(list);
            Console.WriteLine(list.IndexOf(40));
            display(list);
           
            Console.WriteLine("---------");
            list.Clear();
            display(list);
        }
        static void Main(string[] args)
        {
            ArrayListEx1 ex1 = new ArrayListEx1();
            ex1.arrayMethods();
            Console.Read();
        }
    }
}
