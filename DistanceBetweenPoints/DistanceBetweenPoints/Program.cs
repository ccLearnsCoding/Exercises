internal class Program
{
    private static void Main(string[] args)
    {
        // Define the coordinates of two points
        double x1 = 1.0;
        double y1 = 2.0;
        double x2 = 4.0;
        double y2 = 6.0;

        // Calculate the distance between the two points using the distance formula
        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        // Display the coordinates of the two points and the distance
        Console.WriteLine($"Point 1: ({x1}, {y1})");
        Console.WriteLine($"Point 2: ({x2}, {y2})");
        Console.WriteLine($"Distance between points: {distance:F2}");
    }
}