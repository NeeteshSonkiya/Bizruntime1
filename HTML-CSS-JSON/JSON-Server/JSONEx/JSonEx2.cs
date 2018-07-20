using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace JSONEx
{
    class JSonEx2
    {

        static void Main(string[] args)
        {
            var text = "{\"id\":11, \"name\":\"Neetesh\", \"city\":\"Damoh\", \"salary\":34000}";
            Console.WriteLine("Json Data ..");
            Console.WriteLine();
            Console.WriteLine(text);
            Console.WriteLine();
            Console.WriteLine("Json Data in string form");
            Employees s1 = JsonConvert.DeserializeObject<Employees>(text);
            Console.WriteLine("id:" + s1.id);
            Console.WriteLine("name:" + s1.name);
            Console.WriteLine("city:" + s1.city);
            Console.WriteLine("city:" + s1.salary);

            Console.ReadKey();
        }
    }

    class Employees
    {

        public int id { get; set; }
        public string name { get; set; }
        public string city { get; set; }
        public int salary { get; set; }
    }
}