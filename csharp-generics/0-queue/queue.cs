using System;

/// <summary>
/// A generic queue implementation.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    private class Node
    {
        public T Value { get; set; } // Stores the node's value.
        public Node Next { get; set; } // Reference to the next node.

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node Head; // Points to the first node in the queue.
    private Node Tail; // Points to the last node in the queue.
    private int count; // Tracks the number of elements in the queue.

    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        Head = null;
        Tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (Tail == null) // If the queue is empty, set Head as the new node.
        {
            Head = newNode;
        }
        else
        {
            Tail.Next = newNode; // Link the last node to the new node.
        }

        Tail = newNode; // Update Tail to the new node.
        count++;
    }

    /// <summary>
    /// Removes the first element from the queue and returns its value.
    /// </summary>
    /// <returns>The value of the dequeued element, or the default value of T if the queue is empty.</returns>
    public T Dequeue()
    {
        if (Head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T); // Return default value (null for reference types, 0 for value types).
        }

        T value = Head.Value;
        Head = Head.Next;
        count--;

        if (Head == null) // If the queue becomes empty, reset Tail.
        {
            Tail = null;
        }

        return value;
    }

    /// <summary>
    /// Gets the number of elements in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }

    /// <summary>
    /// Gets the type of elements stored in the queue.
    /// </summary>
    /// <returns>The type of elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
