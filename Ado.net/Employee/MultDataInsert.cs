using System;
using System.Data.SqlClient;

namespace ADO
{
    class MultDataInsert
    {
        static void Main(string[] args)
        {
            InsertData();
            Console.ReadKey();
        }
        public static void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                string name, email, str="";
                int id, salary;
                DateTime date;
                do
                {
                    Console.Write("Enter you id : ");
                    id = int.Parse(Console.ReadLine());
                    Console.Write("Enter your name :");
                    name = Console.ReadLine();
                    Console.Write("Enter your email address : ");
                    email = Console.ReadLine();
                    Console.Write("Enter salary : ");
                    salary = int.Parse(Console.ReadLine());
                    Console.Write("Enter join date : ");
                    date = DateTime.Parse(Console.ReadLine());

                    SqlCommand cmd = new SqlCommand("insert into employee(id, name, email, salary, join_date) values(" + id + " , " + name + " , " + email + " , " + salary + "," + date +")", con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Console.WriteLine("Data interted successfully. Do you want to continue ..? press(yes/no)");
                    str = Console.ReadLine();
                    con.Close();
                } while (str.ToLower().Equals("yes"));
                Console.WriteLine("Thank You!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Somthing wrong data not inserted" + ex);
            }
        }
    }
}
