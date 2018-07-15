using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class ObjectEx
    {
        int id;
        string name;
        float salary;
        public ObjectEx(int id, string name, float salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }
        void display()
        {
            Console.WriteLine(id + ". " + name + "  " + salary);
        }
        static void Main(string[] args)
        {
            ObjectEx e1 = new ObjectEx(101, "Rohan", 35000.0f);
            ObjectEx e2 = new ObjectEx(201, "Ganesh", 34000.34f);
            e1.display();
            e2.display();
        }
    }
}
