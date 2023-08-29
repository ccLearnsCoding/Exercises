internal class Program
{
    private static void Main(string[] args)
    {
        // Define four integer variables
        int num1 = 10;
        int num2 = 20;
        int num3 = 30;
        int num4 = 40;

        // Calculate the average as a double precision value
        double average = (num1 + num2 + num3 + num4) / 4.0;

        // Display the result
        Console.WriteLine("The average of {0}, {1}, {2}, and {3} is: {4}", num1, num2, num3, num4, average);
    }
}