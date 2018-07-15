using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
namespace Collection
{
    class ListEx1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee()
            {
                id = 11,
                name = "Rohan",
                salary = 54000
            };
            Employee e2 = new Employee()
            {
                id = 12,
                name = "Manisha",
                salary = 11000
            };
            Employee e3 = new Employee()
            {
                id = 13,
                name = "david",
                salary = 87000
            };
            Employee e4 = new Employee()
            {
                id = 1,
                name = "jorden",
                salary = 18700
            };
            Employee e5 = new Employee()
            {
                id = 3,
                name = "dean",
                salary = 18000
            };


            List<Employee> l = new List<Employee>() { e1, e2, e3, e4, e5 };
            
            Console.WriteLine("Id    Name   Salary");
            Console.WriteLine("--------------------------");
            foreach(Employee emp in l)
            {
                Console.WriteLine( emp.id +"   " + emp.name + "   " + emp.salary);
            }
            Console.Read();
        }
    }
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    }
}
