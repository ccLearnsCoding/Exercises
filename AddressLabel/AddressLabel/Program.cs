internal class Program
{
    private static void Main(string[] args)
    {
        // Initialize variables
        string name = "John Doe";
        string streetAddress = "MockStreetAddress";
        int apartmentNumber = 123;
        string city = "MockCity";
        string state = "MockState";

        // Display the address label
        Console.WriteLine($"{name}");
        Console.WriteLine($"{streetAddress} Apt #{apartmentNumber}");
        Console.WriteLine($"{city}, {state}");
    }
}