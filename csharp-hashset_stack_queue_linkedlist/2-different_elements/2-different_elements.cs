using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        // HashSet to store unique elements from both lists
        HashSet<int> set1 = new HashSet<int>(list1);
        HashSet<int> set2 = new HashSet<int>(list2);
        // HashSet to store elements that are in one of the lists but not both
        HashSet<int> differentElements = new HashSet<int>();

        // Find elements in list1 that are not in list2
        foreach (int num in set1)
        {
            if (!set2.Contains(num))
            {
                differentElements.Add(num);
            }
        }

        // Find elements in list2 that are not in list1
        foreach (int num in set2)
        {
            if (!set1.Contains(num))
            {
                differentElements.Add(num);
            }
        }

        // Convert HashSet to List
        List<int> resultList = new List<int>(differentElements);
        
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
