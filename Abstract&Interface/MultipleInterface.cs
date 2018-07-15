using System;
using System.Collections.Generic;
using System.Text;

namespace Abtstraction
{
    interface IEmployee
    {
        void employeeDetail();
    }
    interface ICustomer
    {
        void customerDetail();
    }
    class MultipleInterface : IEmployee, ICustomer
    {
        public void employeeDetail()
        {
            Console.Write("Emplyoee Name : " + Console.ReadLine());
            Console.WriteLine();
            Console.Write("Employee salary : " + int.Parse(Console.ReadLine()));
        }

        public void customerDetail()
        {
            Console.Write("Customer Name : " + Console.ReadLine());
            Console.WriteLine();
            Console.Write("Customer Address : " + Console.ReadLine());
        }
        static void Main(string[] args)
        {
            IEmployee iemp = new MultipleInterface();
            iemp.employeeDetail();
            Console.WriteLine();
            Console.WriteLine("=====*==*==*===*==*==*=====");
            ICustomer icust = new MultipleInterface();
            icust.customerDetail();
            Console.WriteLine();
            Console.Read();
        }
    }
}
