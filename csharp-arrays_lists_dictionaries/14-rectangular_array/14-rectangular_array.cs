using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a 5x5 two-dimensional array
        int[,] array = new int[5, 5];

        // Initialize the index [2,2] to 1
        array[2, 2] = 1;

        // Loop through the array and print the values
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                // Print each element followed by a space
                Console.Write(array[i, j]);

                // Add space after each element except the last element of the row
                if (j < 4)
                {
                    Console.Write(" ");
                }
            }

            // Add a space after the last element in the row before the newline
            Console.WriteLine(" "); 
        }

        // Extra line to match the expected 56-character output
        Console.WriteLine(); 
    }
}