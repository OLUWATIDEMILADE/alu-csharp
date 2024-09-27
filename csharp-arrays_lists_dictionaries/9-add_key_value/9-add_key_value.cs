using System;
using System.Collections.Generic;

class Dictionary
{
    // Method to add or update a key-value pair in the dictionary
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // Add or update the key-value pair in the dictionary
        myDict[key] = value;

        // Return the updated dictionary
        return myDict;
    }
}