internal class Program
{
    private static void Main(string[] args)
    {
        // Prompt the user to enter a Fahrenheit temperature
        Console.Write("Enter a temperature in Fahrenheit: ");

        // Read the user's input and convert it to a double
        if (double.TryParse(Console.ReadLine(), out double fahrenheit))
        {
            // Convert Fahrenheit to Celsius using the formula (Fahrenheit - 32) * 5/9
            double celsius = (fahrenheit - 32) * 5 / 9;

            // Display the result with one digit to the right of the decimal point
            Console.WriteLine($"Celsius Equivalent: {celsius:F1}°C");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid Fahrenheit temperature.");
        }
    }
}