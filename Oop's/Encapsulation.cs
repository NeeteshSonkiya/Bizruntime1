using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4           //Encapsuation
{
    class ClsEmployee
    {
        int eId;
        string eName;
        string eAddress;
        int eAge;
        public void getData()
        {
            Console.WriteLine("Enter Detail:...");
            eId = int.Parse(Console.ReadLine());
            eName = Console.ReadLine();
            eAddress = Console.ReadLine();
            eAge = int.Parse(Console.ReadLine());
            Console.WriteLine("=============================");
        }
        public void displayData()
        {
            Console.WriteLine("Employee Detail:....");
            Console.WriteLine("Employee-Id is " + eId);
            Console.WriteLine("Employee-Name is " + eName);
            Console.WriteLine("Employee-Address is " + eAddress);
            Console.WriteLine("Employee Age is " + eAge);

        }
    }
    class Encapsulation
    {
        static void Main(string[] args)
        {
            ClsEmployee emp = new ClsEmployee();
            emp.getData();
            emp.displayData();
            Console.ReadKey();
        }
    }
}
