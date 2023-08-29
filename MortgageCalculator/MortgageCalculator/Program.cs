using System;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            try
            {
                double loanAmount, interestRate;
                int loanDurationYears;

                // Get the loan amount from the user
                Console.Write("How much are you borrowing? ");
                if (!double.TryParse(Console.ReadLine(), out loanAmount) || loanAmount <= 0)
                {
                    Console.WriteLine("ERROR: Invalid input for loan amount. Please enter a valid positive number.");
                    if (!GetYesNoResponse("Do you want to get information for another loan (Y/N)? "))
                        break; // Exit the loop if the user's response is not 'Y'
                    continue; // Continue to the next iteration of the loop
                }

                // Get the interest rate from the user
                Console.Write("What is your interest rate? ");
                if (!double.TryParse(Console.ReadLine(), out interestRate) || interestRate <= 0)
                {
                    Console.WriteLine("ERROR: Invalid input for interest rate. Please enter a valid positive number.");
                    if (!GetYesNoResponse("Do you want to get information for another loan (Y/N)? "))
                        break; // Exit the loop if the user's response is not 'Y'
                    continue; // Continue to the next iteration of the loop
                }

                // Get the loan duration in years from the user
                Console.Write("How long is your loan (in years)? ");
                if (!int.TryParse(Console.ReadLine(), out loanDurationYears) || loanDurationYears <= 0)
                {
                    Console.WriteLine("ERROR: Invalid input for loan duration. Please enter a valid positive number of years.");
                    if (!GetYesNoResponse("Do you want to get information for another loan (Y/N)? "))
                        break; // Exit the loop if the user's response is not 'Y'
                    continue; // Continue to the next iteration of the loop
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

                // Ask if the user wants to get information for another loan
                if (!GetYesNoResponse("Do you want to get information for another loan (Y/N)? "))
                    break; // Exit the loop if the user's response is not 'Y'
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
            }
        }
    }
    private static bool GetYesNoResponse(string prompt)
    {
        Console.Write(prompt);
        string response = Console.ReadLine().Trim();
        return response.ToUpper() == "Y";
    }
}