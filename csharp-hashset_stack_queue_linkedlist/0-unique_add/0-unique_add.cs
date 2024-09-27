using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        // Use a HashSet to store unique integers
        HashSet<int> uniqueIntegers = new HashSet<int>(myList);

        // Calculate the sum of unique integers
        int sum = 0;
        foreach (int num in uniqueIntegers)
        {
            sum += num;
        }

        return sum;
    }
}
