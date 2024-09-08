
using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an empty string to hold the alphabet
        string alphabet = "";

        // Use a loop to build the alphabet string
        for (char c = 'a'; c <= 'z'; c++)
        {
            alphabet += c;
        }

        // Print the alphabet string in one go
        Console.Write(alphabet);
    }
}