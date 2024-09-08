using System;

class Program
{
    static void Main(string[] args)
    {
        // Assign the specific number -98
        int number = 98;

        // Calculate the last digit
        int lastDigit = Math.Abs(number % 10);

        // Print the result in the required format
        Console.Write("The last digit of " + number + " is " + lastDigit);

        // Determine which message to print
        if (lastDigit > 5)
        {
            Console.WriteLine(" and is greater than 5");
        }
        else if (lastDigit == 0)
        {
            Console.WriteLine(" and is 0");
        }
        else
        {
            Console.WriteLine(" and is less than 6 and not 0");
        }
    }
}
