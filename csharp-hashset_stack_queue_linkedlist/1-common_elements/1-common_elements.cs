using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        // HashSet to store unique elements from the first list
        HashSet<int> elementsSet = new HashSet<int>(list1);
        // HashSet to store common elements
        HashSet<int> commonElements = new HashSet<int>();

        // Find common elements
        foreach (int num in list2)
        {
            if (elementsSet.Contains(num))
            {
                commonElements.Add(num);
            }
        }

        // Convert HashSet to List
        List<int> resultList = new List<int>(commonElements);
        
        // Sort the list using a simple sorting algorithm (Bubble Sort)
        for (int i = 0; i < resultList.Count - 1; i++)
        {
            for (int j = 0; j < resultList.Count - 1 - i; j++)
            {
                if (resultList[j] > resultList[j + 1])
                {
                    // Swap
                    int temp = resultList[j];
                    resultList[j] = resultList[j + 1];
                    resultList[j + 1] = temp;
                }
            }
        }

        return resultList;
    }
}