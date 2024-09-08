using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty string to hold the alphabet without 'q' and 'e'
        string result = "";

        // Use a loop to build the string
        for (char c = 'a'; c <= 'z'; c++)
        {
            // Append characters that are not 'q' or 'e'
            if (c != 'q' && c != 'e')
            {
                result += c;
            }
        }

        // Print the result string in one go
        Console.Write(result);
    }
}
