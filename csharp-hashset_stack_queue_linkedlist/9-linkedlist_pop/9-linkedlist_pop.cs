using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        if (myLList == null || myLList.Count == 0)
        {
            return 0;
        }

        LinkedListNode<int>? firstNode = myLList.First;
        if (firstNode != null)
        {
            int value = firstNode.Value;
            myLList.RemoveFirst();
            return value;
        }

        return 0;
    }
}
