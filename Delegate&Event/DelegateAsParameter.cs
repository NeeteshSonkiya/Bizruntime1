using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    public class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int salary { get; set; }
        public int experience { get; set; }

        public void promoteEmployee(List<Employee> emp, IsPromotable isPromo)
        {
            foreach ( var e1 in emp)
            {
                if (isPromo(e1))
                {
                    Console.WriteLine("Employee ID : " + e1.Id);
                    Console.WriteLine("Employee Name : " + e1.name);
                    Console.WriteLine("Employee Salary : " + e1.salary);
                    Console.WriteLine();
                }
            }
        }
    }
    public delegate bool IsPromotable(Employee e);
    class DelegateAsParameter
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            list.Add(new Employee() { Id = 01, name = "ansh", salary = 19000, experience = 7 });
            list.Add(new Employee() { Id = 02, name = "shoen", salary = 91000, experience = 4 });
            list.Add(new Employee() { Id = 03, name = "jorden", salary = 29000, experience = 2 });
            list.Add(new Employee() { Id = 04, name = "oliver", salary = 15000, experience = 8 });

            Employee emp = new Employee();
            IsPromotable isPromotable = new IsPromotable(Promote);
            emp.promoteEmployee(list, isPromotable);
            Console.Read();
        }
        public static bool Promote(Employee emp)
        {
            if (emp.experience >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
