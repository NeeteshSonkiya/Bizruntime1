using System;
using System.Collections.Generic;
using System.Text;

namespace Collection
{
    class DictionaryGenericsEx
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer()
            {
                Id = 101,
                name = "john",
                salary = 34000
            };
            Customer c2 = new Customer()
            {
                Id = 102,
                name = "johny",
                salary = 43000
            };
            Customer c3 = new Customer()
            {
                Id = 103,
                name = "john carter",
                salary = 37000
            };
            Dictionary<int, Customer> d1 = new Dictionary<int, Customer>();
            d1.Add(c1.Id, c1);
            d1.Add(c2.Id, c2);
            d1.Add(c3.Id, c3);

            //foreach (KeyValuePair<int, Customer> custo in d1)
            //{
            //    Customer c = custo.Value;
            //    Console.WriteLine(c.Id + " .   " + c.name + "     " + c.salary);
            //}
            //Console.Read();
            Customer cust;
            if (d1.TryGetValue(101, out cust))
            {
                Console.WriteLine("Id = {0} .  name = {1}   salary = {2}", cust.Id, cust.name, cust.salary);
            }
            else
            {
                Console.WriteLine("Id not find");
            }
            d1.Remove(101);
            d1.Clear();
            
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
    }
}
