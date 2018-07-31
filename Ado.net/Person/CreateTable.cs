using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class CreateTable
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand query;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");
                query = new SqlCommand("create table person(id int, name varchar(99), age int, email varchar(99))", con);
                con.Open();
                query.ExecuteNonQuery();
                Console.WriteLine("Table created successfully");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine("some error occured:" + ex);
            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                    con = null;
                }
            }
        }
    }
}
