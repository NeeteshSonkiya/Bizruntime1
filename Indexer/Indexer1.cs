using System;

namespace Indexer
{
    class Student
    {
        int s_id;
        string s_name;
        string s_address;
        public Student(int s_id, string s_name, string s_address)
        {
            this.s_id = s_id;
            this.s_name = s_name;
            this.s_address = s_address;
        }
        public Object this[int index]
        {
            get
            {
                if (index == 0)
                    return s_id;
                else if (index == 1)
                    return s_name;
                else if (index == 2)
                    return s_address;
                else
                    return null;
            }
            set
            {
                if (index == 0)
                    s_id = (int)value;
                else if (index == 1)
                    s_name = (string)value;
                else if (index == 2)
                    s_address = (string)value;
            }
        }
    }
    class Indexer1
    {
        static void Main(string[] args)
        {
            Student stu = new Student(101, "Rohan", "BTM");
            Console.WriteLine(stu[0]);
            Console.WriteLine(stu[1]);
            Console.WriteLine(stu[2]);
            stu[0] = 1001;
            stu[1] = "rahul";
            stu[2] = "hsr";
            Console.WriteLine();
            Console.WriteLine(stu[0]);
            Console.WriteLine(stu[1]);
            Console.WriteLine(stu[2]);
            Console.Read();
        }
    }
}
