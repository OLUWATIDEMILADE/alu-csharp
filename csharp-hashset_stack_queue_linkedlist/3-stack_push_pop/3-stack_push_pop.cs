using System;
using System.Collections.Generic;

class MyStack<T>
{
    private List<T> stackList = new List<T>();

    public int Count()
    {
        return stackList.Count;
    }

    public void Push(T obj)
    {
        stackList.Add(obj);
    }

    public T Pop()
    {
        if (stackList.Count == 0)
        {
            return default(T);
        }
        T item = stackList[stackList.Count - 1];
        stackList.RemoveAt(stackList.Count - 1);
        return item;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        MyStack<int> stack = new MyStack<int>();
        stack.Push(1);
        Console.WriteLine(stack.Count());
    }
}