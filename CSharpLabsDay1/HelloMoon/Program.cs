internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter name");
        string name = Console.ReadLine();
        DisplayMessage(name);
    }
    static void DisplayMessage(string name)
    {
        Console.WriteLine($"Welcome {name}");
    }
}