using System;
using System.Collections.Generic;
using System.Text;

namespace Indexer      //override(ref and out is not supported)
{
    class Employee
    {
        int empId;
        string empName;
        double salary;
        public Employee(int empId, string empName, double salary)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return empId;
                else if (index == 1)
                    return empName;
                else if (index == 2)
                    return salary;
                return null;
            }
        }
        public object this[string name]
        {
            get
            {
                if (name == "empId")
                    return empId;
                else if (name == "empName")
                    return empName;
                else if (name == "salary")
                    return salary;
                return null;
            }
        }
    }
    class Indexer3
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(101, "john", 45000.9);
            Console.WriteLine("Emp id : " + emp[0]);
            Console.WriteLine("Emp Name : " + emp[1]);
            Console.WriteLine("Emp salary : " + emp[2]);
            Console.WriteLine();
            Console.WriteLine("Emp id : " + emp["empId"]);
            Console.WriteLine("Emp Name : " + emp["empName"]);
            Console.WriteLine("Emp salary : " + emp["salary"]);
            Console.Read();
        }
    }
}
