using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        int index = 0;

        foreach (int value in myLList)
        {
            if (index == n)
                return value;
            index++;
        }

        // If n is out of bounds, return 0
        return 0;
    }
}
