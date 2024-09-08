using System;

public class Number
{
    // Method to add two integers
    public static int Add(int a, int b)
    {
        // Return the sum of a and b
        return a + b;
    }

    // Main method to test the Add method
    public static void Main()
    {
        // Test cases
        Console.WriteLine(Add(5, 3));   // Output: 8
        Console.WriteLine(Add(-1, 1));  // Output: 0
        Console.WriteLine(Add(0, 0));   // Output: 0
        Console.WriteLine(Add(123, 456)); // Output: 579
    }
}