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

        // Convert to local time
        DateTime nowLocal = DateTime.Now.ToLocalTime();
        Console.WriteLine($"Current Local Date and Time: {nowLocal}");

        // Convert UTC to a specific time zone
        TimeZoneInfo saTimeZone = TimeZoneInfo.FindSystemTimeZoneById("South Africa Standard Time");
        DateTime saTime = TimeZoneInfo.ConvertTimeFromUtc(now, saTimeZone);
        Console.WriteLine($"South Africa Time: {saTime}");

        // Create a DateTime object for a specific date
        DateTime specificDate = new DateTime(2023, 10, 1);
        Console.WriteLine($"Specific Date: {DateTimeString}");

        // Add days to the current date
        DateTime futureDate = now.AddDays(10);
        Console.WriteLine($"Future Date (10 days later): {futureDate}");

        // Date comparison
        int comparison = DateTime.Compare(now, futureDate);
        Console.WriteLine($"Comparison result (now vs futureDate): {comparison}");

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

        // Display various components of the current date
        Console.WriteLine($"Day of Week: {now.DayOfWeek}");
        Console.WriteLine($"Month: {now.Month}");
        Console.WriteLine($"Year: {now.Year}");
        Console.WriteLine($"Day of Year: {now.DayOfYear}");

        // Display the time component
        TimeOnly timeOnly = TimeOnly.FromDateTime(now);
        Console.WriteLine($"TimeOnly from DateTime: {timeOnly}");

        // Leap year check
        bool isLeap = DateTime.IsLeapYear(now.Year);
        Console.WriteLine($"Is {now.Year} a leap year? {isLeap}");

        // Stopwatch example
        var stopwatch = System.Diagnostics.Stopwatch.StartNew();
        System.Threading.Thread.Sleep(300); // Simulate delay
        stopwatch.Stop();
        Console.WriteLine($"Elapsed Time (ms): {stopwatch.ElapsedMilliseconds}");

        // Parsing a date string
        if (DateTime.TryParse("2025-12-31", out DateTime parsedDate))
        {
            Console.WriteLine($"Successfully parsed: {parsedDate}");
        }
        else
        {
            Console.WriteLine("Failed to parse date.");
        }
    }
}