internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            Console.WriteLine("Choose a scrubbing option:");
            Console.WriteLine("1. Remove leading and trailing spaces");
            Console.WriteLine("2. Remove specific character");
            Console.WriteLine("3. Replace specific character");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                string phoneNumber;
                string scrubbedPhone;

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter a phone number: ");
                        phoneNumber = Console.ReadLine();
                        ScrubPhone(ref phoneNumber);
                        Console.WriteLine($"Scrubbed phone number: {phoneNumber}");
                        break;

                    case 2:
                        Console.Write("Enter a phone number: ");
                        phoneNumber = Console.ReadLine();
                        Console.Write("Enter the character to remove: ");
                        char charToRemove = Console.ReadLine()[0];
                        ScrubPhone(ref phoneNumber, charToRemove);
                        Console.WriteLine($"Scrubbed phone number: {phoneNumber}");
                        break;

                    case 3:
                        Console.Write("Enter a phone number: ");
                        phoneNumber = Console.ReadLine();
                        Console.Write("Enter the character to replace: ");
                        char charToRemove2 = Console.ReadLine()[0];
                        Console.Write("Enter the character to replace with: ");
                        char charToReplaceWith = Console.ReadLine()[0];
                        ScrubPhone(ref phoneNumber, charToRemove2, charToReplaceWith);
                        Console.WriteLine($"Scrubbed phone number: {phoneNumber}");
                        break;

                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }

            Console.Write("Do you want to perform another operation? (y/n): ");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() != "y")
                break;

        } while (true);
    }

    public static void ScrubPhone(ref string phoneNumber)
    {
        phoneNumber = phoneNumber.Trim();
    }

    public static void ScrubPhone(ref string phoneNumber, char charToRemove)
    {
        phoneNumber = phoneNumber.Trim();
        phoneNumber = phoneNumber.Replace(charToRemove.ToString(), "");
    }

    public static void ScrubPhone(ref string phoneNumber, char charToRemove, char charToReplaceWith)
    {
        phoneNumber = phoneNumber.Trim();
        phoneNumber = phoneNumber.Replace(charToRemove, charToReplaceWith);
    }
}