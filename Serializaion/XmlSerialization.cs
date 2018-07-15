using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    
    public class Employee
    {
        private string name;
        private string address;
       
        public string Ename { get; set; }
        public string Eadd { get; set; }
    }
    class XmlSerialization
    {
        public static void callSerializable()
        {
            Employee emp = new Employee();      // { Ename = "ansh", Eadd = "btm" };
            Console.WriteLine("Enter employee detail.... ");
            Console.WriteLine();
            Console.Write("Emplyee Name  : ");
            emp.Ename = Console.ReadLine();
            Console.Write("Employee Address : ");
            emp.Eadd = Console.ReadLine();
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            TextWriter tw = new StreamWriter("F:\\Bizruntime\\Workspace\\Serialization\\h1.xml");
            xs.Serialize(tw, emp);
            Console.WriteLine("Data serialize successfully ");
            tw.Close();
        }

        public static void callDeSerializable()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\h1.xml", FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            Employee emp = (Employee)xs.Deserialize(sr);
            Console.WriteLine("Employee Name is : " + emp.Ename);
            Console.WriteLine("Employee Address is : " + emp.Eadd);
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
