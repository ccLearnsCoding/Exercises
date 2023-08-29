internal class Program
{
    static void Main(string[] args)
    {
        // Get the current date/time
        DateTime currentTime = DateTime.Now;
        TimeSpan currentHour = TimeSpan.FromHours(currentTime.Hour);

        // Display a greeting based on the current time
        string greeting = "";

        if (currentHour >= TimeSpan.FromHours(5) && currentHour < TimeSpan.FromHours(10))
        {
            greeting = "Good morning!";
        }
        else if (currentHour >= TimeSpan.FromHours(10) && currentHour < TimeSpan.FromHours(18))
        {
            greeting = "Good day!";
        }
        else if (currentHour >= TimeSpan.FromHours(18) && currentHour < TimeSpan.FromHours(24))
        {
            greeting = "Good evening!";
        }
        else
        {
            greeting = "Welcome to the late shift!";
        }

        Console.WriteLine($"Time: {currentTime.ToString("hh:mm tt")} - {greeting}");
    }
}