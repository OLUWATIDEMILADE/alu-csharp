using System;

class Program
{
    static void Main(string[] args)
    {
        // Use a loop to generate numbers from 0 to 98
        for (int i = 0; i <= 98; i++)
        {
            // Only print '1' if the current number is 1
            if (i == 1)
            {
                Console.Write("1");
            }
        }
    }
}
