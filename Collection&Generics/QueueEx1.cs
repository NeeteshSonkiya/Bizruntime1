using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class QueueEx1
    {
        static void Main(string[] args)
        {
            Student s1 = new Student()
            {
                s_id = 101,
                s_name = "ansh",
                s_addess = "BTM-1",
                contact = 8770345187
            };
            Student s2 = new Student()
            {
                s_id = 102,
                s_name = "chndra",
                s_addess = "BTM-2",
                contact = 8812921389
            };
            Student s3 = new Student()
            {
                s_id = 103,
                s_name = "ashok",
                s_addess = "BTM-3",
                contact = 9893232374
            };

            Queue<Student> q = new Queue<Student>();
            q.Enqueue(s1);
            q.Enqueue(s2);
            q.Enqueue(s3);
            int a = 0;
            Console.WriteLine("Enter your id..");
            int fid = int.Parse(Console.ReadLine());
            foreach(Student s in q)
            {
                if (s.s_id == fid)
                {
                    Console.WriteLine(s.s_id + " . " + s.s_name + "   " + s.s_addess + "  " + s.contact);
                    a++;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(" record not found");
            }
            Console.Read();
        }
    }
    class Student
    {
        public int s_id { get; set; }
        public string s_name { get; set; }
        public string s_addess { get; set; }
        public long contact { get; set; }
    }
}
