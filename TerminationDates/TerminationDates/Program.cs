using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        // Prompt the user for the insurance policy renewal date
        Console.Write("Enter the policy renewal date (DD/MM/YYYY): ");
        if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime renewalDate))
        {
            // Calculate the end of a 10-day grace period
            DateTime gracePeriodEndDate = renewalDate.AddDays(10);

            // Calculate the date 1 month in the future
            DateTime cancelDate = renewalDate.AddMonths(1);

            // Display the calculated dates
            Console.WriteLine();
            Console.WriteLine("Policy Renewal Date: " + renewalDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("End of 10-Day Grace Period: " + gracePeriodEndDate.ToString("dd/MM/yyyy"));
            Console.WriteLine("Cancellation Date for Lack of Payment (1 Month in the Future): " + cancelDate.ToString("dd/MM/yyyy"));
        }
        else
        {
            Console.WriteLine("Invalid date format. Please use DD/MM/YYYY format.");
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}