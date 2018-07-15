using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Collection
{
    class ListEx4
    {
        static void Main(string[] args)
        {
            Emp e1 = new Emp { id = 10, name = "rahul", salary = 10000 };
            Emp e2 = new Emp { id = 11, name = "rohan", salary = 12000 };
            Emp e3 = new Emp { id = 5, name = "ashok", salary = 13000 };
            Emp e4 = new Emp { id = 7, name = "abhay", salary = 14000 };
            Emp e5 = new Emp { id = 2, name = "ashis", salary = 6000 };
            Emp e6 = new Emp { id = 12, name = "chandra",salary = 9000 };

            List<Emp> l = new List<Emp>() { e1, e2, e3, e4, e5, e6 };
            CompareEmp cmp = new CompareEmp();
            l.Sort(cmp);
            foreach(Emp e in l)
            {
                Console.WriteLine(e.id + "   "+ e.name + "    " + e.salary);
            }
            Console.Read();
        }
    }
    public class CompareEmp : IComparer<Emp>
    {
        int IComparer<Emp>.Compare(Emp x, Emp y)
        {
            if (x.salary > y.salary)
                return 1;
            else if (x.salary < y.salary)
                return -1;
            else
                return 0;
        }
    }
    public class Emp : IComparable<Emp>
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }

        int IComparable<Emp>.CompareTo(Emp other)
        {
            if (this.id > other.id)
                return 1;
            else if (this.id < other.id)
                return -1;
            else
                return 0;
        }
    }
}
