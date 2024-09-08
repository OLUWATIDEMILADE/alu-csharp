using System;

public class Line
{
    // Method to print a straight line of underscores
    public static void PrintLine(int length)
    {
        // Check if length is greater than 0
        if (length > 0)
        {
            // Print the underscore character 'length' times
            for (int i = 0; i < length; i++)
            {
                Console.Write('_');
            }
        }
        
        // Print a new line at the end
        Console.WriteLine();
    }

    // Main method to test the PrintLine method
    public static void Main()
    {
        // Test cases
        PrintLine(5);    // Output: _____
        PrintLine(0);    // Output: (newline)
        PrintLine(-3);   // Output: (newline)
        PrintLine(10);   // Output: ________ 
    }
}
