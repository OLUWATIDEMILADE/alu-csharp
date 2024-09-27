using System;
using System.Collections.Generic;

class Dictionary
{
    // Method to return the number of keys in a dictionary
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int count = 0;

        // Iterate through the keys in the dictionary
        foreach (var key in myDict.Keys)
        {
            count++;
        }

        return count;
    }
}
