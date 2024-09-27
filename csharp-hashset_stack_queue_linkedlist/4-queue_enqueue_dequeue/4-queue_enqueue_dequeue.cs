using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        // Print the number of items in the queue
        Console.WriteLine($"Number of items: {aQueue.Count}");

        // Print the first item or indicate that the queue is empty
        if (aQueue.Count > 0)
        {
            Console.WriteLine($"First item: {aQueue.Peek()}");
        }
        else
        {
            Console.WriteLine("Queue is empty");
        }

        // Add the new item to the queue
        aQueue.Enqueue(newItem);

        // Check if the queue contains the search item
        bool containsSearch = aQueue.Contains(search);
        Console.WriteLine($"Queue contains \"{search}\": {containsSearch}");

        // If the queue contains the search item, remove all items up to and including search
        if (containsSearch)
        {
            Queue<string> tempQueue = new Queue<string>();

            // Dequeue items until we find the search item
            while (aQueue.Count > 0)
            {
                string item = aQueue.Dequeue();
                if (item == search)
                {
                    break; // Stop when we find the search item
                }
                tempQueue.Enqueue(item); // Store items in tempQueue
            }

            // Restore items back to aQueue
            while (tempQueue.Count > 0)
            {
                aQueue.Enqueue(tempQueue.Dequeue());
            }
        }

        // Return the modified queue
        return aQueue;
    }
}
