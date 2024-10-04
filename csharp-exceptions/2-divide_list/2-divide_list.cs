using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> result = new List<int>();

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                if (i >= list1.Count || i >= list2.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (list2[i] == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    result.Add(0);
                }
                else
                {
                    result.Add(list1[i] / list2[i]);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                // Do not add `0` to the result for out-of-range cases.
            }
        }

        return result;
    }
}