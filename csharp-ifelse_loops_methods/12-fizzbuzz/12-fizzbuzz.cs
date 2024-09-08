using System;

public class FizzBuzz
{
    public static void Main()
    {
        // Loop from 1 to 100
        for (int i = 1; i <= 100; i++)
        {
            // Check if the number is a multiple of both 3 and 5
            if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FizzBuzz ");
            }
            // Check if the number is a multiple of 3
            else if (i % 3 == 0)
            {
                Console.Write("Fizz ");
            }
            // Check if the number is a multiple of 5
            else if (i % 5 == 0)
            {
                Console.Write("Buzz ");
            }
            // For all other numbers, print the number itself
            else
            {
                Console.Write(i + " ");
            }
        }
        
        // Print a new line at the end
        Console.WriteLine();
    }
}
