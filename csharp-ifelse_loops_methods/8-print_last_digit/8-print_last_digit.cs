using System;

public class Number
{
    // Method to get the last digit of a number
    public static int PrintLastDigit(int number)
    {
        // Get the last digit using modulo 10
        int lastDigit = Math.Abs(number) % 10;
        
        // Print the last digit
        Console.WriteLine(lastDigit);
        
        // Return the last digit
        return lastDigit;
    }

    // Main method to test the PrintLastDigit method
    public static void Main()
    {
        // Test cases
        PrintLastDigit(123);   // Output: 3
        PrintLastDigit(-456);  // Output: 6
        PrintLastDigit(7890);  // Output: 0
        PrintLastDigit(1);     // Output: 1
        PrintLastDigit(0);     // Output: 0
    }
}
