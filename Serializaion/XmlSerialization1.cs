using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.IO;

namespace Serialization
{
    [Serializable]
    public class SEmployee
    {
    
        public string Name { get; set; }
    
        public int Age { get; set; }
    
        public string Address { get; set; }
    }
    class XmlSerialization1
    {
        static void GetEmployeeDetail(out SEmployee[] emp)
        {
            Console.WriteLine("Enter number of record u want to enter...");
            int n = int.Parse(Console.ReadLine());
            emp = new SEmployee[n];
            for (int i = 0; i < n; i++)
            {
                emp[i] = new SEmployee();
                Console.Write("Employee Name : ");
                emp[i].Name = Console.ReadLine();
                Console.Write("Employee Age : ");
                emp[i].Age = int.Parse(Console.ReadLine());
                Console.Write("Employee Address : ");
                emp[i].Address = Console.ReadLine();
                Console.WriteLine();
            }
        }
        public static void CallSerialization()
        {
            SEmployee[] emp;
            GetEmployeeDetail(out emp);
            XmlSerializer xs = new XmlSerializer(typeof(SEmployee[]));
            TextWriter tw = new StreamWriter(@"F:\\Bizruntime\\Workspace\\Serialization\\test.xml");
            xs.Serialize(tw, emp);
            Console.WriteLine("Data serialize successfully");
            Console.WriteLine();
            tw.Close();
        }
        static void CallDeserialization()
        {
            StreamReader sr = new StreamReader("F:\\Bizruntime\\Workspace\\Serialization\\test.xml");
            XmlSerializer xs = new XmlSerializer(typeof(SEmployee[]));
            SEmployee[] emp = (SEmployee[])xs.Deserialize(sr);
            Console.WriteLine("SEmployee after Desrialization ..");
            foreach(var e1 in emp)
            {
                Console.WriteLine("Employee Name : " + e1.Name);
                Console.WriteLine("Employee Age : " + e1.Age);
                Console.WriteLine("Employee Address : " + e1.Address);
                Console.WriteLine();
                sr.Close();
            }
        }
        static void Main(string[] args)
        {
            CallSerialization();
            CallDeserialization();
            Console.ReadLine();
        }
    }
}
