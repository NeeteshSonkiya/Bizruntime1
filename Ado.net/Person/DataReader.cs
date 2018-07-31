using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class DataReader
    {
        static void getData()
        {
            SqlConnection con = null;
            SqlCommand query;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");
                query = new SqlCommand("select * from person", con);
                con.Open();
                SqlDataReader data = query.ExecuteReader();
                while (data.Read())
                {
                    Console.WriteLine(data[0] + "," + data[1] + "," + data[2] + "," + data[3]);

                }
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
        static void Main(string[] args)
        {
            getData();
            Console.ReadKey();
        }
    }
}