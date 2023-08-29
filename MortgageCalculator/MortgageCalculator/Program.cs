using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Get the loan amount from the user
        Console.Write("How much are you borrowing? ");
        if (!double.TryParse(Console.ReadLine(), out double loanAmount))
        {
            Console.WriteLine("Invalid input for loan amount. Please enter a valid number.");
            return;
        }

        // Get the interest rate from the user
        Console.Write("What is your interest rate? ");
        if (!double.TryParse(Console.ReadLine(), out double interestRate))
        {
            Console.WriteLine("Invalid input for interest rate. Please enter a valid number.");
            return;
        }

        // Get the loan duration in years from the user
        Console.Write("How long is your loan (in years)? ");
        if (!int.TryParse(Console.ReadLine(), out int loanDurationYears))
        {
            Console.WriteLine("Invalid input for loan duration. Please enter a valid number of years.");
            return;
        }

        // Calculate the monthly payment
        double monthlyInterestRate = interestRate / 1200; // Convert annual interest rate to monthly
        int numberOfPayments = loanDurationYears * 12;
        double monthlyPayment = (loanAmount * monthlyInterestRate) / (1 - Math.Pow(1 + monthlyInterestRate, -numberOfPayments));
        double totalPayment = monthlyPayment * numberOfPayments;
        double totalInterest = totalPayment - loanAmount;

        // Display the result
        Console.WriteLine($"Your estimated payment is {monthlyPayment:C}");
        Console.WriteLine($"You paid {totalPayment:C} over the life of the loan");
        Console.WriteLine($"Your total interest cost for the loan was {totalInterest:C}");
    }
}