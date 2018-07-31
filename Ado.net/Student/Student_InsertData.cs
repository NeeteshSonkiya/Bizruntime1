using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO2
{
    class Student_InsertData
    {
        static void Main(string[] args)
        {
            InsertData();
        }
        public static void InsertData()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
                // writing sql query  
                SqlCommand cm = new SqlCommand("insert into student(id, name, email, join_date)values('101', 'Ronald Trump', 'ronald@example.com', '1/12/2017')", con);  
                    // Opening Connection  
                con.Open();
                // Executing the SQL query  
                cm.ExecuteNonQuery();
                // Displaying a message  
                Console.WriteLine("Record Inserted Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
