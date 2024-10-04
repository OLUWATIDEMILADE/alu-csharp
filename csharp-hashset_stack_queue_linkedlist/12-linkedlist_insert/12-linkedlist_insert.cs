using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        // Create the new node
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        // If the list is empty or the new value is smaller than the first node
        if (myLList.First == null || n < myLList.First.Value)
        {
            myLList.AddFirst(newNode);
        }
        else
        {
            // Traverse the list to find the correct insertion point
            LinkedListNode<int> current = myLList.First;
            while (current.Next != null && current.Next.Value < n)
            {
                current = current.Next;
            }

            // Insert the new node after the current node
            myLList.AddAfter(current, newNode);
        }

        // Return the newly created node
        return newNode;
    }
}
