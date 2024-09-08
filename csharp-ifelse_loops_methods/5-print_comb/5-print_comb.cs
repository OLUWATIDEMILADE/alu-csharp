using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a variable to accumulate the output string
        string output = "";

        // Loop from 0 to 99
        for (int i = 0; i < 100; i++)
        {
            // Append the number with leading zero if necessary and followed by ", " unless it's the last number
            output += i.ToString("D2");
            if (i < 99)
            {
                output += ", ";
            }
        }

        // Print the accumulated output string followed by a newline
        Console.WriteLine(output);
    }
}