internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize variables
        string name = "Caleb Chan";
        string streetAddress = "123 Main St";
        int apartmentNumber = 456;
        string city = "Anytown";
        string state = "CA";

        // Display the address label
        Console.WriteLine($"{name}");
        Console.WriteLine($"{streetAddress} Apt #{apartmentNumber}");
        Console.WriteLine($"{city}, {state}");
    }
}