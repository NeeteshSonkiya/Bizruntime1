using System;
using System.Data.SqlClient;

namespace ADO
{
    class CreatingConnection
    {

        static void Main(string[] args)
        {
            Connecting();
        }
        public static void Connecting()
        {
            SqlConnection con = null;
            try
            {
                //creating connection
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);
            }
            finally
            {
                //closing connection
                con.Close();
            }
        }
    }
}