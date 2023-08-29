internal class Program
{
    private static void Main()
    {
        string choice;
        do
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. CtoF (Convert Celsius to Fahrenheit)");
            Console.WriteLine("2. FtoC (Convert Fahrenheit to Celsius)");
            Console.WriteLine("3. Quit");

            choice = Console.ReadLine();

            switch (choice.ToLower())
            {
                case "1":
                case "ctof":
                    double convertedFahrenheit;
                    Console.Write("Enter a Celsius temperature: ");
                    if (double.TryParse(Console.ReadLine(), out double celsius))
                    {
                        convertedFahrenheit = ConvertCtoF(celsius);
                        Console.WriteLine($"{celsius} degrees in Celsius is {convertedFahrenheit} degrees in Fahrenheit");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "2":
                case "ftoc":
                    double convertedCelcius;
                    Console.Write("Enter a Fahrenheit temperature: ");
                    if (double.TryParse(Console.ReadLine(), out double fahrenheit))
                    {
                        convertedCelcius = ConvertFtoC(fahrenheit);
                        Console.WriteLine($"{fahrenheit} degrees in Fahrenheit is {convertedCelcius} degrees in Celsius");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    break;

                case "3":
                case "quit":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

        } while (choice.ToLower() != "3" && choice.ToLower() != "quit");
    }
    static double ConvertCtoF(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double ConvertFtoC(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}