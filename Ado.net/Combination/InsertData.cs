using System;
using System.Data.SqlClient;

namespace ADO3
{
    class InsertData
    {
        static readonly log4net.ILog log = log4net.LogManager.GetLogger(typeof(InsertData));

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

        public void Insert()
        {
            log.Info("Enter table name ::");
            string tableName = Console.ReadLine();
            if (tableName.Equals("Orders"))
            {
                InsertIntoOrder();
            }
            else if (tableName.Equals("Customers"))
            {
                InsertIntoCustomers();
            }
            else
            {
                log.Error("You have select wrong table!");
                log.Info("Do you want to try again(yes/no)?");
                string choice = Console.ReadLine();
                if (choice == "yes")
                {
                    Insert();
                }
            }
        }

        public void InsertIntoOrder()
        {

            try
            {
                string choice = null;
                do
                {
                    log.Info("Enter OrderId :: ");
                    int orderId = Convert.ToInt32(Console.ReadLine());
                    log.Info("Enter OrderName :: ");
                    string orderName = Console.ReadLine();
                    log.Info("Enter CustomerId :: ");
                    int customerId = Convert.ToInt32(Console.ReadLine());
                    log.Info("Enter price :: ");
                    int price = Convert.ToInt32(Console.ReadLine());

                    string insertCommand = @"insert into Orders values (" + orderId + ",'" + orderName + "'," + customerId + "," + price + ")";

                    SqlCommand command = new SqlCommand(insertCommand, connection);

                    command.ExecuteNonQuery();
                    log.Info("Data inserted successfully!");
                    log.Info("Do you want to enter more details(yes/no)?");
                    choice = Console.ReadLine();
                }
                while (choice == "yes");
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

        public void InsertIntoCustomers()
        {
            try
            {
                string choice = null;
                do
                {
                    log.Info("Enter CustomerId :: ");
                    int customerId = Convert.ToInt32(Console.ReadLine());
                    log.Info("Enter customerName :: ");
                    string customerName = Console.ReadLine();
                    log.Info("Enter customerAge :: ");
                    int customerAge = Convert.ToInt32(Console.ReadLine());
                    log.Info("Enter customerAddress :: ");
                    string address = Console.ReadLine();

                    string insertCommand = @"insert into Customers values (" + customerId + ",'" + customerName + "'," + customerAge + ",'" + address + "')";

                    SqlCommand command = new SqlCommand(insertCommand, connection);
                    command.ExecuteNonQuery();
                    log.Info("Data inserted successfully!");
                    log.Info("Do you want to enter more details(yes/no)?");
                    choice = Console.ReadLine();
                }
                while (choice == "yes");

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
