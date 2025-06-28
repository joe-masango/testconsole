using Oracle.ManagedDataAccess.Client;

namespace Databases;

public class OracleDb
{
    public static void Connect()
    {
        try
        {
            // Replace with your actual connection string
            string connectionString = "User Id=myUsername;Password=myPassword;Data Source=myDataSource";
            using var connection = new OracleConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connected to Oracle Database");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Oracle connection failed: {ex.Message}");
        }
    }
}