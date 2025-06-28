using MongoDB.Driver;

namespace Databases;

public class MongoDb
{
    public static void Connect()
    {
        try
        {
            // Replace with your actual connection string
            string connectionString = "mongodb://localhost:27017/mydatabase";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("mydatabase");
            Console.WriteLine("Connected to MongoDB");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"MongoDB connection failed: {ex.Message}");
        }
    }
}