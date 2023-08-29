internal class Program
{
    public static void ScrubPhone(ref string phoneNumber)
    {
        phoneNumber = phoneNumber.Trim(); // Removes leading and trailing spaces
    }

    static void Main(string[] args)
    {
        do
        {
            Console.Write("Enter a phone number: ");
            string phoneNumber = Console.ReadLine();

            // Call the ScrubPhone method to remove leading and trailing spaces
            ScrubPhone(ref phoneNumber);

            Console.WriteLine($"Scrubbed phone number: {phoneNumber}");

            Console.Write("Do you want to enter another phone number? (y/n): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "y")
                break;

        } while (true);

        Console.WriteLine("Goodbye!");
    }
}