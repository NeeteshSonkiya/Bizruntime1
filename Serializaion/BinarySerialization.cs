using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

namespace Serialization
{
    [Serializable]
   public class Student
    {
        public int id;
        public string name;
        public string address;

        public Student(int id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }
    }
    class BinarySerialization
    {
        public static void callSerialization()
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\hello.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Student s = new Student(101, "raman", "HSR");
            bf.Serialize(fs, s);
            fs.Close();
        }
        public static void callDeserialization()
        {
            FileStream fs = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\hello.txt", FileMode.OpenOrCreate);
            BinaryFormatter bf = new BinaryFormatter();
            Student s = (Student)bf.Deserialize(fs);
            Console.WriteLine("Student ID : " + s.id);
            Console.WriteLine("Student Name : " + s.name);
            Console.WriteLine("Student Address : " + s.address);
            fs.Close();
        }
        static void Main(string[] args)
        {
            callSerialization();
            callDeserialization();
            Console.Read();
        }
    }
}
