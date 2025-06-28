using Npgsql;

namespace Databases;

public class PostgresSql
{
    public static void Connect()
    {
        try
        {
            // Replace with your actual connection string
            string connectionString = "Host=localhost;Username=postgres;Password=mypassword;Database=mydb";

            using var connection = new NpgsqlConnection(connectionString);
            connection.Open();

            Console.WriteLine("Connected to PostgreSQL");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"PostgreSQL connection failed: {ex.Message}");
        }
    }
}