internal class Program
{
    public static void Main(string[] args)
    {
        double[] scores = { 85.5, 90.0, 78.5, 92.5, 88.0, 75.0, 89.5 };

        double average = GetAverage(scores);
        double mean = GetMean(scores);
        double largest = GetLargestValue(scores);
        double smallest = GetSmallestValue(scores);

        Console.WriteLine("Scores: " + string.Join(", ", scores));
        Console.WriteLine("Average: " + average);
        Console.WriteLine("Mean: " + mean);
        Console.WriteLine("Largest Value: " + largest);
        Console.WriteLine("Smallest Value: " + smallest);
    }
    public static double GetAverage(double[] scores)
    {
        if (scores.Length == 0)
            throw new ArgumentException("The scores array cannot be empty.");

        double sum = 0;
        foreach (double score in scores)
        {
            sum += score;
        }
        return sum / scores.Length;
    }

    public static double GetMean(double[] scores)
    {
       return GetAverage(scores); // mean = average
    }

    public static double GetLargestValue(double[] scores)
    {
        if (scores.Length == 0)
            throw new ArgumentException("The scores array cannot be empty.");

        double largest = scores[0];
        foreach (double score in scores)
        {
            if (score > largest)
                largest = score;
        }
        return largest;
    }

    public static double GetSmallestValue(double[] scores)
    {
        if (scores.Length == 0)
            throw new ArgumentException("The scores array cannot be empty.");

        double smallest = scores[0];
        foreach (double score in scores)
        {
            if (score < smallest)
                smallest = score;
        }
        return smallest;
    }
}