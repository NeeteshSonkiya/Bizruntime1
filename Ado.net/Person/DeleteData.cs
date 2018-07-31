using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class DeleteData
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            SqlCommand query;

            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");

                con.Open();
                query = new SqlCommand("delete person where id = 2", con);

                int status = query.ExecuteNonQuery();
                if (status == 1)
                {
                    Console.WriteLine("deleted succssfully :" + status);
                }
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
            Console.ReadKey();
        }
    }
}