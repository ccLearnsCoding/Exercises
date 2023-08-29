internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a year: ");
        if (int.TryParse(Console.ReadLine(), out int year))
        {
            if (IsLeapYear(year))
            {
                Console.WriteLine($"{year} is a leap year in the Gregorian calendar.");
            }
            else
            {
                Console.WriteLine($"{year} is not a leap year in the Gregorian calendar.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid year.");
        }
    }
    static bool IsLeapYear(int year)
    {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
        {
            return true;
        }
        return false;
    }
}