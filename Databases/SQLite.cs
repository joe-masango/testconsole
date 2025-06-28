using System.Data.SQLite;

namespace Databases;

public class SQLite
{
    public static void Connect()
    {
        try
        {
            // Replace with your actual connection string
            string connectionString = "Data Source=mydatabase.db;Version=3;";
            using var connection = new SQLiteConnection(connectionString);
            connection.Open();
            Console.WriteLine("Connected to SQLite");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"SQLite connection failed: {ex.Message}");
        }
    }
}