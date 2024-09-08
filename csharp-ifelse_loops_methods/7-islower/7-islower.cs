using System;

public class Character
{
    // Method to check if the character is lowercase
    public static bool IsLower(char c)
    {
        // Check if the character's ASCII value is between 'a' and 'z'
        return c >= 'a' && c <= 'z';
    }

    // Main method to test the IsLower method
    public static void Main()
    {
        // Test cases
        Console.WriteLine(IsLower('a'));  // True
        Console.WriteLine(IsLower('z'));  // True
        Console.WriteLine(IsLower('A'));  // False
        Console.WriteLine(IsLower('Z'));  // False
        Console.WriteLine(IsLower('1'));  // False
        Console.WriteLine(IsLower(' '));  // False
    }
}