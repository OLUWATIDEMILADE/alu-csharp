using System;
using System.Collections.Generic;

class Dictionary
{
    // Method to multiply all values by 2 and return a new dictionary
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        // Create a new dictionary to store the modified values
        Dictionary<string, int> newDict = new Dictionary<string, int>();

        // Iterate through the original dictionary
        foreach (KeyValuePair<string, int> entry in myDict)
        {
            // Multiply the value by 2 and add it to the new dictionary
            newDict[entry.Key] = entry.Value * 2;
        }

        // Return the new dictionary
        return newDict;
    }
}