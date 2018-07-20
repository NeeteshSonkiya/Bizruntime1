using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace JSONEx
{
    class JSonEx1
    {

        static void Main(string[] args)
        {
            var client = new WebClient();
            var text = "{\"id\":11, \"name\":\"Neetesh\", \"city\":\"Damoh\"}";

            Console.WriteLine(text);

            Student s1 = JsonConvert.DeserializeObject<Student>(text);
            Console.WriteLine("id:" + s1.id);
            Console.WriteLine("name:" + s1.name);
            Console.WriteLine("city:" + s1.city);

            Console.ReadKey();
        }
    }

    class Student
    {

        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
    }
}