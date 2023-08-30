namespace MultiplicationTable
{
    internal class Program
    {
        static void Main()
        {
            int[,] mathTable = CreateArray();

            // Fill the multiplication table
            for (int i = 0; i < mathTable.GetLength(0); i++) // 10 rows
            {
                for (int j = 0; j < mathTable.GetLength(1); j++) // 5 columns
                {
                    mathTable[i, j] = i * j; // multiplication table
                }
            }

            // Column Headings
            Console.Write("    ");
            for (int j = 0; j < mathTable.GetLength(1); j++)
            {
                Console.Write("{0,6}", j);
            }
            Console.WriteLine(); // Newline after column headings

            // Separator line
            Console.Write("    ");
            for (int j = 0; j < mathTable.GetLength(1); j++)
            {
                Console.Write("{0,6}", "---");
            }
            Console.WriteLine(); // Newline after separator

            for (int i = 0; i < mathTable.GetLength(0); i++)
            {
                // Row Label
                Console.Write("{0,2} |", i);

                for (int j = 0; j < mathTable.GetLength(1); j++)
                {
                    Console.Write("{0,6}", mathTable[i, j]);
                }

                Console.WriteLine(); // Move to the next row
            }

            Console.ReadKey(); // Keep the console window open
        }

        static public int[,] CreateArray()
        {
            int[,] table = new int[10, 5];
            return table;
        }
    }
}