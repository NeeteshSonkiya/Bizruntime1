using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class InsertData
    {
        static void insertData()
        {
            SqlConnection con = null;
            SqlCommand query;
            string choice;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");
                con.Open();
                do
                {
                    Console.WriteLine("enter id:");
                    int id = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("enter name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("enter age:");
                    int age = Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine("enter email:");
                    string email = Console.ReadLine();

                    query = new SqlCommand("insert into person values(" + id + ",'" + name + "'," + age + ",'" + email + "')", con);

                    query.ExecuteNonQuery();

                    Console.WriteLine("Do u Want to insert one more record?Y/N");
                    choice = Console.ReadLine();
                }
                while (choice.ToLower() == "y");
                Console.WriteLine("records inserted successfully");
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
            insertData();
            Console.ReadKey();
        }
    }
}