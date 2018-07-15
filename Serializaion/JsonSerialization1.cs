using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.IO;
namespace Serialization
{
    [DataContract]
    public class Manager
    {
        [DataMember]
        public int id { get; set; }
        [DataMember]
        public string name { get; set; }
        [DataMember]
        public string address { get; set; }   
    }
    class JsonSerialization1
    {
        static void callSerializer()
        {
            Manager m = new Manager() { id = 01, name = "arun", address = "shantinagar" };
            FileStream fs = new FileStream(@"F:\Bizruntime\Workspace\Serialization\js.json", FileMode.OpenOrCreate);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Manager));
            serializer.WriteObject(fs, m);
            Console.WriteLine("Serialization is done...");
            fs.Close();
        }
        static void callDeserializer()
        {
            FileStream fs = new FileStream(@"F:\Bizruntime\Workspace\Serialization\js.json", FileMode.Open);
            DataContractJsonSerializer deSerializer = new DataContractJsonSerializer(typeof(Manager));
            Manager m1 = (Manager)deSerializer.ReadObject(fs);
            Console.WriteLine("Manager id  : " + m1.id);
            Console.WriteLine("Manager name  : " + m1.name);
            Console.WriteLine("Manager address  : " + m1.address);
            fs.Close();
        }
        static void Main(string[] args)
        {
            callSerializer();
            callDeserializer();
            Console.Read();
        }
    }
}
