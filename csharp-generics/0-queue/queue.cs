using System;

/// <summary>
/// A generic queue implementation.
/// </summary>
/// <typeparam name="T">The type of elements in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// A node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T Value { get; set; }

        /// <summary>
        /// Gets or sets the next node in the queue.
        /// </summary>
        public Node Next { get; set; }

        /// <summary>
        /// Initializes a new node with the specified value.
        /// </summary>
        /// <param name="value">The value to store in the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Gets the first node in the queue.
    /// </summary>
    public Node Head { get; private set; }

    /// <summary>
    /// Gets the last node in the queue.
    /// </summary>
    public Node Tail { get; private set; }

    // Stores the number of nodes in the queue.
    private int count;

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
        if (Tail == null)
        {
            Head = newNode;
        }
        else
        {
            Tail.Next = newNode;
        }
        Tail = newNode;
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
            return default(T); // Returns default value (null for reference types, 0 for numeric types)
        }

        T value = Head.Value;
        Head = Head.Next;
        count--;

        // If the queue is now empty, reset Tail to null.
        if (Head == null)
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
