using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class ListEx2
    {
        static void Main(string[] args)
        {
            Student1 s1 = new Student1()
            {
                id = 101,
                name = "ansh",
                addess = "BTM-1",
                contact = 8770345187
            };
            Student1 s2 = new Student1()
            {
                id = 102,
                name = "chndra",
                addess = "BTM-2",
                contact = 8812921389
            };
            Student1 s3 = new Student1()
            {
                id = 103,
                name = "ashok",
                addess = "BTM-3",
                contact = 9893232374
            };

            List<Student1> l = new List<Student1>();
            l.Add(s1);
            l.Add(s2);
            l.Add(s3);
            int a = 0;

            foreach (Student1 s in l)
            {
                if (s.id == 102)
                {
                    l.Remove(s);
                    Console.WriteLine("record deleted...");
                    a++;
                }
                Console.WriteLine(s.id + " . " + s.name + "   " + s.addess + "  " + s.contact);
            }
            if (a == 0)
            {
                Console.WriteLine(" record not found");
            }
            Console.Read();
        }
    }
    class Student1
    {
        public int id { get; set; }
        public string name { get; set; }
        public string addess { get; set; }
        public long contact { get; set; }
    }
}
