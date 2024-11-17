// 1-instance.cs
using System;

class Obj
{
    public static bool IsInstanceOfArray(object obj)
    {
        return obj is Array;
    }
}