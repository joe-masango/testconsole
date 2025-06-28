namespace Dates;

public class DateTimes
{
    public const string DateTimeString = "2025-06-28T00:00:00+00:00";

    public static void Dates()
    {
        Console.WriteLine("Date and Time Operations using DateTime.UtcNow\n");
        // Create a DateTime object for the current date and time
        DateTime now = DateTime.UtcNow;
        Console.WriteLine($"Current Date and Time: {now}");
        // Create a DateTime object for a specific date
        DateTime specificDate = new DateTime(2023, 10, 1);
        Console.WriteLine($"Specific Date: {DateTimeString}");
        // Add days to the current date
        DateTime futureDate = now.AddDays(10);
        Console.WriteLine($"Future Date (10 days later): {futureDate}");
        // Calculate the difference between two dates
        TimeSpan difference = futureDate - now;
        Console.WriteLine($"Difference in days: {difference.TotalDays}");

        Console.WriteLine("\nDate and Time Operations using Custom Date 2025-01-01 00:00:00\n");
        // Create a DateTime object for a custom date
        DateTimeOffset dateTimeOffset = DateTimeOffset.Parse(DateTimeString);
        Console.WriteLine($"Parsed DateTimeOffset: {dateTimeOffset}");
        // Convert DateTimeOffset to DateTime
        DateOnly dateOnly = DateOnly.FromDateTime(dateTimeOffset.Date);
        Console.WriteLine($"DateOnly from DateTimeOffset: {dateOnly}");
        // Convert DateTimeOffset to DateTime with Kind
        var dateOlyKind = DateOnly.FromDateTime(DateTime.Parse(DateTimeString, null, System.Globalization.DateTimeStyles.RoundtripKind));
        Console.WriteLine($"DateOnly with Kind from DateTime: {dateOlyKind}");
    }
}
