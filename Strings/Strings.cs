using System.Text;

public class Strings
{
    public static void StringOperations()
    {
        Console.WriteLine("=== String Operations Showcase ===\n");

        // Basic string declaration
        string greeting = "Hello, world!";
        Console.WriteLine($"Original String: {greeting}");

        // String length
        Console.WriteLine($"Length: {greeting.Length}");

        // Substring
        Console.WriteLine($"Substring (0, 5): {greeting.Substring(0, 5)}");

        // ToUpper and ToLower
        Console.WriteLine($"Uppercase: {greeting.ToUpper()}");
        Console.WriteLine($"Lowercase: {greeting.ToLower()}");

        // Contains and IndexOf
        Console.WriteLine($"Contains 'world': {greeting.Contains("world")}");
        Console.WriteLine($"Index of 'world': {greeting.IndexOf("world")}");

        // Replace
        string replaced = greeting.Replace("world", "C#");
        Console.WriteLine($"Replaced: {replaced}");

        // Trim
        string padded = "   padded string   ";
        Console.WriteLine($"Trimmed: '{padded.Trim()}'");

        // Split
        string csv = "apple,banana,cherry";
        string[] fruits = csv.Split(',');
        Console.WriteLine("Split CSV:");
        foreach (var fruit in fruits)
        {
            Console.WriteLine($"- {fruit}");
        }

        // Join
        string joined = string.Join(" | ", fruits);
        Console.WriteLine($"Joined: {joined}");

        // String interpolation
        string name = "Joe";
        int age = 30;
        Console.WriteLine($"Interpolated: My name is {name} and I am {age} years old.");

        // StringBuilder for performance
        StringBuilder sb = new StringBuilder();
        sb.Append("This ");
        sb.Append("is ");
        sb.Append("a ");
        sb.Append("StringBuilder ");
        sb.Append("example.");
        Console.WriteLine($"StringBuilder: {sb}");

        // Null or empty/whitespace checks
        string empty = "";
        Console.WriteLine($"IsNullOrEmpty: {string.IsNullOrEmpty(empty)}");
        Console.WriteLine($"IsNullOrWhiteSpace: {string.IsNullOrWhiteSpace("   ")}");

        // Escape characters
        string path = "C:\\Users\\Joe\\Documents";
        Console.WriteLine($"Escaped Path: {path}");

        // Verbatim string
        string verbatim = @"C:\Users\Joe\Documents";
        Console.WriteLine($"Verbatim Path: {verbatim}");
    }
}