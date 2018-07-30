using System;
using System.Data.SqlClient;

namespace ADO
{
    class DataInsertion
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

               // SqlCommand cmd = new SqlCommand("insert into employee(id, name, email, salary, join_date) values('101', 'Ansh', 'ansh@gmail.com', '12000', '01/12/2017')", con);
                SqlCommand cmd = new SqlCommand("insert into employee(id, name, email, salary, join_date) values('102', 'Anshuman', 'anshu@gmail.com', '24000', '02/12/2008')", con);

                con.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data interted successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine("Somthing wrong data not inserted" + ex);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
