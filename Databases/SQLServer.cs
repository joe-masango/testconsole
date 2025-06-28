using Microsoft.Data.SqlClient;

namespace Databases;

public class SQLServer
{
    public static void Connect()
    {
        try
        {
            // Replace with your actual connection string
            string connectionString = "Server=localhost;Database=MyDb;Trusted_Connection=True;";

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connected to SQL Server");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"SQL Server connection failed: {ex.Message}");
        }
    }
}