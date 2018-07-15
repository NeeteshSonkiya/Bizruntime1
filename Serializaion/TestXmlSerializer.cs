using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Student1
    {
        public string sName { get; set; }
        public int sAge { get; set; }
        public string sAdd { get; set; }
    }
    class TestXmlSerializer
    {
        static void callSerialization()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student1));
            Student1 s1 = new Student1() { sName = "ansh", sAge = 18, sAdd = "btm" };
            TextWriter tw = new StreamWriter("F:\\Bizruntime\\Workspace\\Serialization\\hello2.xml");
            xs.Serialize(tw, s1);
            Console.WriteLine("serialize successfully");
            tw.Close();
        }
        static void callDeSerialization()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Student1));
            TextReader tr = new StreamReader("F:\\Bizruntime\\Workspace\\Serialization\\hello1.xml");
            Student1 s = (Student1)xs.Deserialize(tr);
            Console.WriteLine("Student Name : " + s.sName);
            Console.WriteLine("Student Age : " + s.sAge);
            Console.WriteLine("Student Address : " + s.sAdd);
        }
        static void Main(string[] args)
        {
            callSerialization();
            callDeSerialization();
            Console.Read();
        }
    }
}
