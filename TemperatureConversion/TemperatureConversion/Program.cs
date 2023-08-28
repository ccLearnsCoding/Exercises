internal class Program
{
    private static void Main(string[] args)
    {
        // Define the Fahrenheit temperature
        double fahrenheit = 69.5;

        // Convert Fahrenheit to Celsius using the formula: (°F - 32) * 5/9
        double celsius = (fahrenheit - 32) * 5 / 9;

        // Display the temperatures with the degree symbol (°)
        Console.WriteLine($"Fahrenheit: {fahrenheit:F1}°F");
        Console.WriteLine($"Celsius: {celsius:F1}°C");
    }
}