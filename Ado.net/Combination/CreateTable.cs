using System;
using System.Data.SqlClient;

namespace ADO3
{
    /// <summary>
    /// This class is designed for performing create table operation on sqlserver.It is having a function which will be creating a table when ever called.
    /// </summary>
    class CreateTable
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(CreateTable));



        /// <summary>
        /// This method is being used for creating a table.
        /// </summary>
        public void CreateTableMethod()
        {
            SqlConnection con = null;

            try
            {
                log.Info("Enter Table Name :: ");
                string tableName = Console.ReadLine();
                
                //string address = @"Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True";
                con = new SqlConnection("Data Source=DESKTOP-4EEFVUL\\SQLEXPRESS;Initial Catalog=Customer;Integrated Security=True");
                con.Open();
                log.Info("Connected to DB!");

                //SqlCommand command = new SqlCommand("create table " + tableName + "(customerId int not null, customerName varchar(100), customerAge int, address varchar(100))", con);
                SqlCommand command = new SqlCommand("create table " + tableName + "(orderId int not null, orderName varchar(100), customerId int, price int)", con);
                command.ExecuteNonQuery();
                log.Info("Table created succesfully!");

            }
            catch (Exception e)
            {
                log.Error("Error ::" + e.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
