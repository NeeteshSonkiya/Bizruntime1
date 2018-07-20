using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

using System.IO;

namespace JSONEx
{
    [DataContract]
    class JsonSerialization
    {
        [DataMember]
        public int id;
        [DataMember]
        public string name;
        [DataMember]
        public string place;

        public JsonSerialization(int id, string name, string place)
        {
            this.id = id;
            this.name = name;
            this.place = place;
        }

        static void CallSerializer()
        {
            JsonSerialization e1 = new JsonSerialization(1, "Arun", "gwalior");

            FileStream stream = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\h2.json", FileMode.OpenOrCreate);

            //serializes the object to JSON
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JsonSerialization));

            ser.WriteObject(stream, e1);
            Console.WriteLine("Data Serialized successfully..");
            stream.Close();
        }
        static void CallDeSerializer()
        {
            DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(JsonSerialization));
            FileStream stream = new FileStream("F:\\Bizruntime\\Workspace\\Serialization\\h2.json", FileMode.Open);
    
            JsonSerialization e2 = (JsonSerialization)ser.ReadObject(stream);

            Console.WriteLine("deserialization done :" + e2.id + "," + e2.name + "," + e2.place);
            stream.Close();
        }
        static void Main(string[] args)
        {
            CallSerializer();
            CallDeSerializer();
            Console.ReadKey();
        }
    }
}