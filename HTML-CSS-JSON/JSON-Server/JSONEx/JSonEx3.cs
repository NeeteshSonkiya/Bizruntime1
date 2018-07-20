using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.IO;
using Newtonsoft.Json;

namespace JSONEx
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return String.Format("Name: {0} \nAge: {1}", Name, Age);
        }
    }
    class JSonEx3
    {
        static void Main(string[] args)
        {
            string JSONstring = File.ReadAllText(@"db.json");
            JavaScriptSerializer ser = new JavaScriptSerializer();
            Person p1 = ser.Deserialize<Person>(JSONstring);
            Console.WriteLine(p1);

            Person p2 = new Person{ Name = "ben", Age = 46 };
            string out_Json = JsonConvert.SerializeObject(p2);
            File.WriteAllText("out.json", out_Json);
            Console.ReadKey();
        }
    }
}
