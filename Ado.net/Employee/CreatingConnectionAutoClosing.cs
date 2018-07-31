using System;
using System.Data.SqlClient;

namespace ADO
{
    class CreatingConnectionAutoClosing
    {

        static void Main(string[] args)
        {
            Connecting();
            Console.ReadKey();
        }
        public static void Connecting()
        {
            // Creating Connection  
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Employee;Integrated Security=True"))
            {
                con.Open();
                Console.WriteLine("Connection Established Successfully");
            }
        }
    }
}
