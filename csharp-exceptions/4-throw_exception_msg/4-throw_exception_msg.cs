using System;

public class Except
{
    public static void ThrowMsg(string msg)
    {
        // Throwing an exception with a custom message
        throw new Exception(msg);
    }
}