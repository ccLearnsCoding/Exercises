namespace FileTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get the current date and time
            DateTime currentTime = DateTime.Now;

            // Format the date and time as yyyymmddhhmmss
            string formattedDateTime = currentTime.ToString("yyyyMMddHHmmss");

            // Get the current directory
            string currentDirectory = Directory.GetCurrentDirectory();

            // List all files in the current directory
            string[] files = Directory.GetFiles(currentDirectory);

            Console.WriteLine("Files in the current directory:");

            foreach (string file in files)
            {
                Console.WriteLine(Path.GetFileName(file));
            }

            // Create a new file named test.txt with random text
            string filePath = Path.Combine(currentDirectory, "test.txt");
            File.WriteAllText(filePath, "This is some random text.");

            Console.WriteLine("test.txt created with random text.");

            // Create a backup file with the formatted date and time
            string backupFileName = $"test-backup-{formattedDateTime}.txt";
            string backupFilePath = Path.Combine(currentDirectory, backupFileName);

            File.Copy(filePath, backupFilePath);

            Console.WriteLine($"{backupFileName} created as a backup.");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}