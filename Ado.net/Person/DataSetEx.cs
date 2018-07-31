using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO1
{
    class DataSetEx
    {
        static void retrieveData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Person;Integrated Security=True");
                con.Open();
                DataSet dataSet = new DataSet();
                SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from person", con);
                SqlCommandBuilder dataBuilder = new SqlCommandBuilder(dataAdapter);
                dataAdapter.Fill(dataSet, "table1");
                int i = 0;
                /*foreach (DataTable table in dataSet.Tables)
                { 
                    Console.WriteLine(table.Rows[i].ToString());
                    i++;
                }*/
                Console.WriteLine("id" + "\t" + "name" + "\t" + "age" + "\t" + " email" + "\t");
                Console.WriteLine("========================================");
                foreach (DataRow dr in dataSet.Tables[0].Rows)
                {
                    Console.WriteLine(dr["id"] + "\t" + dr["name"] + "\t" + dr["age"] + "\t" + dr["email"]);
                }


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
        }
        static void Main(string[] args)
        {
            retrieveData();
            Console.ReadKey();
        }
    }
}