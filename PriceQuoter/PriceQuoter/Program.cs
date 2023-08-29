internal class Program
{
    private static void Main(string[] args)
    {
        // Define product prices
        decimal bg127Price = 18.99m;
        decimal wrtr28Price = 125.00m;
        decimal guac8Price = 8.99m;

        // Prompt user for input
        Console.Write("Enter the product code (BG-127, WRTR-28, GUAC-8): ");
        string productCode = Console.ReadLine().ToUpper(); // Convert to uppercase for case-insensitivity

        if (productCode != "BG-127" && productCode != "WRTR-28" && productCode != "GUAC-8")
        {
            Console.WriteLine("Invalid product code.");
            return;
        }

        Console.Write("Enter the quantity: ");
        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
        {
            Console.WriteLine("Invalid quantity.");
            return;
        }

        // Calculate the total price
        decimal totalPrice = 0;

        switch (productCode)
        {
            case "BG-127":
                if (quantity >= 1 && quantity <= 24)
                    totalPrice = bg127Price * quantity;
                else if (quantity >= 25 && quantity <= 50)
                    totalPrice = 17.00m * quantity;
                else if (quantity >= 51)
                    totalPrice = 14.49m * quantity;
                break;

            case "WRTR-28":
                if (quantity >= 1 && quantity <= 24)
                    totalPrice = wrtr28Price * quantity;
                else if (quantity >= 25 && quantity <= 50)
                    totalPrice = 113.75m * quantity;
                else if (quantity >= 51)
                    totalPrice = 99.99m * quantity;
                break;

            case "GUAC-8":
                if (quantity >= 1 && quantity <= 24)
                    totalPrice = guac8Price * quantity;
                else if (quantity >= 25 && quantity <= 50)
                    totalPrice = 8.99m * quantity;
                else if (quantity >= 51)
                    totalPrice = 7.49m * quantity;
                break;
        }

        // Apply large order discount
        if (quantity >= 250)
        {
            decimal discountAmount = totalPrice * 0.15m;
            decimal discountedTotal = totalPrice - discountAmount;

            Console.WriteLine("Large Order Discount Applied (15%)");
            Console.WriteLine($"Product Code: {productCode}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Per Unit Price: ${totalPrice / quantity:F2}");
            Console.WriteLine($"Total Price: ${discountedTotal:F2}");
        }
        else
        {
            Console.WriteLine($"Product Code: {productCode}");
            Console.WriteLine($"Quantity: {quantity}");
            Console.WriteLine($"Per Unit Price: ${totalPrice / quantity:F2}");
            Console.WriteLine($"Total Price: ${totalPrice:F2}");
        }
    }
}