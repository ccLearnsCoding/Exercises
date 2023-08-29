internal class Program
{
    static void Main(string[] args)
    {
        do
        {
            GetData(out string studentName, out string majorCode, out string classification);

            string advisingLocation = GetAdvisingLocation(majorCode, classification);

            Console.WriteLine($"Advising for {majorCode} {classification} majors: {advisingLocation}");

            Console.Write("Do you want to enter another? (y/n): ");
        } while (Console.ReadLine().Trim().ToUpper() == "Y");
    }

    static void GetData(out string studentName, out string majorCode, out string classification)
    {
        Console.Write("What is the student's name? ");
        studentName = Console.ReadLine();

        Console.Write("What is the student's major? ");
        majorCode = Console.ReadLine().ToUpper();

        Console.Write("What is the student's classification? ");
        classification = Console.ReadLine().Trim();
    }

    static string GetAdvisingLocation(string majorCode, string classification)
    {
        string advisingLocation;

        switch (majorCode)
        {
            case "BIOL":
                advisingLocation = (classification == "Freshman" || classification == "Sophomore") ? "Science Bldg, Room 310" : "Science Bldg, Room 311";
                break;
            case "CSCI":
                advisingLocation = "Sheppard Hall, Room 314";
                break;
            case "ENG":
                advisingLocation = (classification == "Freshman") ? "Kerr Hall, Room 201" : "Kerr Hall, Room 312";
                break;
            case "HIST":
                advisingLocation = "Kerr Hall, Room 114";
                break;
            case "MKT":
                advisingLocation = (classification != "Senior") ? "Westly Hall, Room 310" : "Westly Hall, Room 313";
                break;
            default:
                advisingLocation = "Unknown major code";
                break;
        }
        return advisingLocation;
    }
}