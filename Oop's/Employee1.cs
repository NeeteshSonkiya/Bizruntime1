using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class Address
    {
        public int hNumber;
        public string city;
        public string nation;
        public Address(int hn, string c, string na)
        {
            this.hNumber = hn;
            this.city = c;
            this.nation = na;
        }
    }
    class Employee1
    {
        public int id;
        public string name;
        public Address address;
        public Employee1(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
        public void display()
        {
            Console.WriteLine(id + ". " + name + "  " + address.hNumber + " ," + address.city + "," + address.nation);
        }
        static void Main(string[] args)
        {
            Address a1 = new Address(101, "Delhi", "india");
            Employee1 e1 = new Employee1(1, "Kurt", a1);
            e1.display();
            Console.ReadKey();
        }
    }
}
