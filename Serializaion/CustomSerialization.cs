using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace serialization
{

    public class student1 : ISerializable
    {
        public int id;
        public string name;
        public string place;
      
		public student1(int id, string name, string place)
     
			{

			this.id = id;
  
			this.name = name;
 
			this.place = place;

        
			}
        public student1(SerializationInfo info, StreamingContext context)
        {
            id = Convert.ToInt16(info.GetValue("id1", typeof(int)));
            name = Convert.ToString(info.GetValue("name1", typeof(string)));
            place = Convert.ToString(info.GetValue("place1", typeof(string)));

        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("id1", id, typeof(int));
            info.AddValue("name1", name, typeof(string));
            Console.WriteLine("hello..........");
            info.AddValue("place1", place, typeof(string));
        }
    }
    class binary_serialization_using_ISerializable
    {

        static void Main(string[] args)
        {
            student1 s1 = new student1(201, "arjun", "hyderabad");
            Console.WriteLine(s1.id);
            Console.WriteLine(s1.name);
            Console.WriteLine(s1.place);

           FileStream file = new FileStream(@"F:\\Bizruntime\\Workspace\\Serialization\\custom.txt", FileMode.OpenOrCreate);
           BinaryFormatter format = new BinaryFormatter();
           format.Serialize(file, s1);
           file.Close();
            Console.ReadKey();
        }
    }
}