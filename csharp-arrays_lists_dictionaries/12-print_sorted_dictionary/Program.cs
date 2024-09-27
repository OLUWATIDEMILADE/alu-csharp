using System;
using System.Collections.Generic;

class Dictionary
{
    // Method to print the dictionary sorted by keys
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Create a list of keys
        List<string> sortedKeys = new List<string>(myDict.Keys);

        // Sort the list of keys alphabetically
        sortedKeys.Sort();

        // Print each key-value pair in the sorted order
        foreach (string key in sortedKeys)
        {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
