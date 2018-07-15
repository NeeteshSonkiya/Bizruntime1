using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    [Serializable]
    class Employee1
    {
        public string name { get; set; }
        public int age { get; set; }
        public double salary { get; set; }
    }
    class BinarySrialization1
    {
        static void callSerializable()
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\f1.xlsx", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee1 emp1 = new Employee1() { name ="arun", age = 18, salary = 19000 };
            bf.Serialize(fs, emp1);
            Console.WriteLine("Data serialize successfully ");
            fs.Close();
        }
        static void callDeSerializable()
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\f1.xlsx", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Employee1 emp = (Employee1)bf.Deserialize(fs);
            Console.WriteLine("Employee Name : " + emp.name);
            Console.WriteLine("Employee age : " + emp.age);
            Console.WriteLine("Employee salary : " + emp.salary);
            fs.Close();
        }
        static void Main(string[] args)
        {
            callSerializable();
            callDeSerializable();
            Console.Read();
        }
    }
}
