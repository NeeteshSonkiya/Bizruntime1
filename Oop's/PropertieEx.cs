using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class PropertieEx
    {
        private string name;
        private string company;
        public string Name          //field properties
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value + "Pvt. Ltd";
            }
        }
        static void Main(string[] args)
        {
            PropertieEx c9 = new PropertieEx();
            c9.Name = "Johny";
            c9.Company = "Google ";
            Console.WriteLine("Name - " + c9.name);
            Console.WriteLine("Company - " + c9.company);
            Console.ReadKey();
        }
    }
}
