using System;

namespace ConsoleApp4       //creating object and using for the access instance variable
{
    class Student
    {
        int id;
        string name;

        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();
            s1.id = 1;
            s1.name = "john";
            s2.id = 2;
            s2.name = "Oliver";

            Console.Write(s1.id + ". ");
            Console.WriteLine(s1.name);

            Console.Write(s2.id + ". ");
            Console.WriteLine(s2.name);
            Console.ReadKey();
        }
    }
}
