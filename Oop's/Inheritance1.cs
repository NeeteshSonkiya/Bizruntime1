using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4   //single level inheritance
{
    public class Parents
    {
        public int id = 101;
        public string name = "johny deep";
        public void display()
        {
            Console.WriteLine(id + ".  " + name);
        }

    }
    class Inheritance1:Parents
    {
        int salary = 32000;
        static void Main(string[] args)
        {
            Inheritance1 c6 = new Inheritance1();
            Console.WriteLine(c6.id + "." + c6.name + "  " + c6.salary);
            c6.id = 101;
            c6.name = "Rohan";
            c6.display();
            Console.ReadKey();
        }
    }
}
