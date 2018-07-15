using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays
{
    class AccessingArrayValue
    {
        static string[] name = new string[5];
        static int[] age = new int[5];
        static int j;
        public void students()
        {
            
            for (int i = 0; i<name.Length; i++)
            {
                Console.WriteLine("Enter your Name and Age..");
                name[i] = Console.ReadLine();
                age[i] = int.Parse(Console.ReadLine());
            }
        }
        public void findStudentAge()
        {
            string n;
            Console.WriteLine("Enter your name to find the age..");
            n = Console.ReadLine();
            for (int i = 0; i< name.Length; i++)
            {
                if (name[i] == n)
                {
                    Console.WriteLine("Your Name is : " + name[i]);
                    Console.WriteLine("Your Age is : " + age[i]);
                    j++;
                }
            }
            if (j == 0)
            {
                Console.WriteLine("Not Found");
            }
        }
        static void Main(string[] args)
        {
            AccessingArrayValue a = new AccessingArrayValue();
            a.students();
            a.findStudentAge();
            Console.ReadKey();
        }
    }
}
