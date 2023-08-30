internal class Program
{
    static void Main(string[] args)
    {
        string[] questions = {
            "Q: Why did the cow have to stand up while watching TV? ",
            "Q: What do you call terrifying Cow dreams? ",
            "Q: What does a cow say in a traffic jam?",
            "Q: How does a cow know what day it is?",
            "Q: Why doesn't Sweden export its cattle?",
            "Q: Where do cows eat?",
            "Q: What was a cow's favorite subject in school?",
            "Q: Where do cows go on vacation?",
            "Q: What do you call the hair under a cow's nose?",
            "Q: What newspaper do cows read?",
            "Q: What kind of exercise do cows like?",
            "Q: What do you call a cow with a sunburn?",
            "Q: What do you call a cow that just gave birth?"
        };

        string[] answers = {
            "A: She didn't have a coooow-ch!",
            "A: Night moooos!",
            "A: Moo0000-ve!",
            "A: She looks at her cow-an-der!",
            "A: It wants to keep its \"Stockholm\"!",
            "A: In a Calf-e-teria!",
            "A: Cow-cul-us!",
            "A: To Ber-mooo-da!",
            "A: A mooooo stache!",
            "A: The Daily Moos!",
            "A: Cow-a-stenics!",
            "A: Roast beef!",
            "A: DeCALFenated!"
        };

        Random random = new Random();

        do
        {
            // Generate a random index to select a joke
            int randomIndex = random.Next(0, questions.Length);

            // Display the selected joke
            Console.WriteLine(questions[randomIndex]);
            Console.WriteLine(answers[randomIndex]);

            Console.WriteLine("\nWant another joke? (y/n): ");
            string response = Console.ReadLine().Trim();

            if (response.ToLower() != "y")
            {
                break; // Exit the loop if the user doesn't want another joke
            }

        } while (true);

        Console.WriteLine("\nThanks for enjoying our goofy jokes!");
    }
}