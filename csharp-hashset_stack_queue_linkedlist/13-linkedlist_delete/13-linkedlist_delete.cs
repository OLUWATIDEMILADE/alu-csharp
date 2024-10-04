using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        // If the index is out of range, do nothing
        if (index < 0 || index >= myLList.Count)
        {
            return;
        }

        // Find the node at the given index
        LinkedListNode<int>? current = myLList.First;
        for (int i = 0; i < index; i++)
        {
            current = current?.Next;
        }

        // If current is not null, remove the node
        if (current != null)
        {
            myLList.Remove(current);
        }
    }
}