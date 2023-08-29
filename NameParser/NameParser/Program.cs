internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a name in the format 'First Middle Last' (e.g., Brenda Kaye Graham):");
        string inputName = Console.ReadLine();

        // Split the input string into name parts
        string[] nameParts = inputName.Split(' ');

        // Determine the number of parts
        int numParts = nameParts.Length;

        // Initialize variables for first name, middle name, and last name
        string firstName = "";
        string middleName = "";
        string lastName = "";

        // Extract name parts based on the number of parts

        if (numParts == 2)
        {
            firstName = nameParts[0];
            lastName = nameParts[1];
        }
        if (numParts == 3)
        {
            firstName = nameParts[0];
            middleName = nameParts[1];
            lastName = nameParts[2];
        }

        // Display the parsed name
        Console.WriteLine("\nParsed Name:");
        Console.WriteLine($"Name: {inputName}");
        Console.WriteLine($"First name: {firstName}");
        Console.WriteLine($"Middle name: {(string.IsNullOrEmpty(middleName) ? "<undefined>" : middleName)}");
        Console.WriteLine($"Last name: {lastName}");

        Console.ReadLine(); // Pause to see the result
    }
}