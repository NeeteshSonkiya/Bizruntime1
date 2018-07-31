using System;
using System.Data.SqlClient;
namespace ADO
{
    class DeleteData
    {
        static void Main(string[] args)
        {
            DeleteRow();
            Console.ReadKey();
        }
        public static void DeleteRow()
        {
            SqlConnection con = null;
            try
            {
               
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True");
               
                SqlCommand cm = new SqlCommand("delete from employee", con);
               
                con.Open();
               
                cm.ExecuteNonQuery();

                Console.WriteLine("Record Deleted Successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + ex);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
