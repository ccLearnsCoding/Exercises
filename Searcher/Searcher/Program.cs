internal class Program
{
    static void Main(string[] args)
    {
        string[] items = { "Sausage Breakfast Taco", "Potato and Egg Breakfast Taco", "Sausage and Egg Biscuit", "Bacon and Egg Biscuit", "Pancakes" };
        decimal[] prices = { 3.99M, 3.29M, 3.70M, 3.99M, 4.79M };

        Console.Write("Enter the food you want to order: ");
        string userChoice = Console.ReadLine();

        decimal? price = FindItemPrice(items, prices, userChoice);

        if (price.HasValue)
        {
            Console.WriteLine($"The price of {userChoice} is ${price.Value:F2}");
        }
        else
        {
            Console.WriteLine($"{userChoice} is not on the menu.");
        }
    }

    static decimal? FindItemPrice(string[] items, decimal[] prices, string item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (string.Equals(items[i], item, StringComparison.OrdinalIgnoreCase))
            {
                return prices[i];
            }
        }
        return null;
    }
}