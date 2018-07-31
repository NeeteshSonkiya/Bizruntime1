using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class ExecuteScaler
    {

        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {

                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");

                SqlCommand query = new SqlCommand("Select count(*) from person", con);

                con.Open();

                int count = (int)query.ExecuteScalar();
                Console.WriteLine("Total No. Of Records in table are:" + count);
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e);
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