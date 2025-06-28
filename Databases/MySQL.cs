using MySql.Data.MySqlClient;

namespace Databases;

public class MySQL
{
    public static void Connect()
    {
        try
        {
            // Replace with your actual connection string
            string connectionString = "Server=localhost;Database=mydb;User=root;Password=mypassword;";

            using MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connected to MySQL");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"MySQL connection failed: {ex.Message}");
        }
    }
}