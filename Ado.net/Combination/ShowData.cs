using System;
using System.Data.SqlClient;

namespace ADO3
{
    class ShowData
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CreateTable));

        SqlConnection connection = null;
        public void OpenConnection()
        {
            try
            {
                //string address = @"Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
                connection = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True");
                connection.Open();
                log.Info("Connected to DB!");
            }
            catch (Exception e)
            {
                log.Error("Error :: " + e.Message);
            }
        }

        public void GetData()
        {
            log.Info("Enter Table Name ::");
            string Tname = Console.ReadLine();
            string getData = "";
            if (Tname.Equals("Orders"))
            {
                getData = "Select * from Orders";
            }
            else if (Tname.Equals("Customers"))
            {
                getData = "Select * from Customers";
            }
            else
            {
                log.Error("Table not found");
            }
            try
            {
                SqlCommand command = new SqlCommand(getData, connection);
                SqlDataReader reader = command.ExecuteReader();

                for (int i = 1; i < reader.FieldCount; i++)
                {
                    Console.Write(reader.GetName(i) + "\t ");
                }

                Console.WriteLine("\n========================================================================================");

                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + "," + reader[1] + "," + reader[2] + "," + reader[3]);
                }
                Console.WriteLine("========================================================================================");
            }
            catch (Exception e)
            {
                log.Error("Error :: " + e.Message);
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
