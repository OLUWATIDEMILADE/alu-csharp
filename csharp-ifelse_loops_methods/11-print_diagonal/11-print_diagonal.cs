using System;

public class Line
{
    // Method to print a diagonal line of backslashes
    public static void PrintDiagonal(int length)
    {
        // Check if length is greater than 0
        if (length > 0)
        {
            for (int i = 0; i < length; i++)
            {
                // Print spaces followed by a backslash
                Console.WriteLine(new string(' ', i) + '\\');
            }
        }
        else
        {
            // Print a new line if length is 0 or less
            Console.WriteLine();
        }
    }

    // Main method to test the PrintDiagonal method
    public static void Main()
    {
        // Test cases
        PrintDiagonal(5);    // Output: 
                             // \
                             //  \
                             //   \
                             //    \
                             //     \
                             
        PrintDiagonal(0);    // Output: (newline)
        PrintDiagonal(-3);   // Output: (newline)
        PrintDiagonal(3);    // Output: 
                             // \
                             //  \
                             //   \
    }
}
