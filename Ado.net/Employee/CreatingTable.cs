using System;
using System.Data.SqlClient;

namespace ADO
{
    class CreatingTable
    {
        static void Main(string[] args)
        {
            CreateTable();
            Console.ReadKey();
        }
        public static void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");

                SqlCommand cmd = new SqlCommand("create table employee(id int not null, name varchar(100), email varchar(50), salary int, join_date date)", con);

                con.Open();

                cmd.ExecuteNonQuery();

                Console.WriteLine("Table created successfully ..");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oop's somthing wrong table not created ");
            }
            finally
            {
                con.Close();
            }
        }

    }
}
