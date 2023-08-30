using System.Globalization;

namespace PayrollFileProcessor
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the file name (e.g., Payroll1.txt or Payroll2.txt):");
            string fileName = Console.ReadLine();

            string logFileName = "PayrollFileProcessor.log";

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    double totalGrossPay = 0;

                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();

                        if (line.Length >= 35)
                        {
                            string id = line.Substring(0, 5).Trim();
                            string name = line.Substring(5, 20).Trim();
                            double payRate = double.Parse(line.Substring(25, 5), CultureInfo.InvariantCulture);
                            double hoursWorked = double.Parse(line.Substring(30, 5), CultureInfo.InvariantCulture);

                            double grossPay = CalculateGrossPay(payRate, hoursWorked);
                            totalGrossPay += grossPay;

                            Console.WriteLine($"ID: {id}, Name: {name}, Gross Pay: ${grossPay:F2}");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid record format: {line}");
                        }
                    }

                    Console.WriteLine($"Gross pay totals were ${totalGrossPay:N2}");

                    using (StreamWriter logWriter = File.AppendText(logFileName))
                    {
                        string logEntry = $"Processing file: {fileName} on {DateTime.Now:MM-dd-yyyy hh:mm:ss tt}.\n" +
                                          $"Gross pay totals were ${totalGrossPay:N2}";
                        logWriter.WriteLine(logEntry);
                        logWriter.WriteLine("----");
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine($"File not found: {fileName}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        static double CalculateGrossPay(double payRate, double hoursWorked)
        {
            const double overtimeRate = 1.5;
            const double maxRegularHours = 40;

            if (hoursWorked <= maxRegularHours)
            {
                return payRate * hoursWorked;
            }
            else
            {
                double regularPay = payRate * maxRegularHours;
                double overtimeHours = hoursWorked - maxRegularHours;
                double overtimePay = overtimeHours * payRate * overtimeRate;
                return regularPay + overtimePay;
            }
        }
    }
}