using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4       //store and display employee detail
{
    class ObjeectEx1
    {
        int id;
        string fName, lName;
        static void Main(String[] args)
        {
            ObjeectEx1 e1 = new ObjeectEx1();
            ObjeectEx1 e2 = new ObjeectEx1();
            e1.insert(1, "Barry", "Allen");
            e2.insert(2, "Cisco", "Roman");
            e1.display();
            e2.display();
            Console.ReadKey();
        }
        public void insert(int i, string fn, string ln)
        {
            id = i;
            fName = fn;
            lName = ln;
        }
        public void display()
        {
            Console.WriteLine(id + ". " + fName + " " + lName);
        }
    }
}
