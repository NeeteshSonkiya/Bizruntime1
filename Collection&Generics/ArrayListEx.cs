using System;
using System.Collections;

namespace Collection    //Add, Insert/insertRange, remove/removeRange, removeAt, 
{                         
    class ArrayListEx
    { 
        public void arrayListMethod()
        {
            ArrayList list = new ArrayList();
            list.Add(12);
            list.Add("hello");
            list.Add(70);
            list.Add(80);
            list.Add(90);
            list.Add(100);
            foreach(var val in list)
            Console.WriteLine(val);
            Console.WriteLine("-----------------");
            list.Insert(1, 10);
            foreach(var val in list)
            Console.WriteLine(val);
            Console.WriteLine("------------------");

            ArrayList list1 = new ArrayList();
            list1.Add(20);
            list1.Add(30);
            list1.Add(40);
            foreach(var val in list1)
            Console.WriteLine(val);
            Console.WriteLine("----------------------");
            list1.InsertRange(1, list);
            foreach(var val in list1)
            Console.WriteLine(val);
            Console.WriteLine("-----------------------");
            list1.Remove("hello");
            foreach(var val in list1)
            Console.WriteLine(val);
            Console.WriteLine("---------------------");
            list1.RemoveRange(0, 3);
            list1.RemoveAt(1);
            foreach(var val in list1)
            Console.WriteLine(val);
        }
        static void Main(string[] args)
        {
            ArrayListEx ex = new ArrayListEx();
            ex.arrayListMethod();
            Console.WriteLine("=====+========+=======+=======+======");
            Console.Read();
        }
    }
}
