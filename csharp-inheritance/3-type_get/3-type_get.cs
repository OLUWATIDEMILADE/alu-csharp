// 3-type_get.cs
using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();
        Console.WriteLine("{0} Properties:", objType.Name);

        // Get properties
        foreach (PropertyInfo property in objType.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine("{0} Methods:", objType.Name);

        // Get methods
        foreach (MethodInfo method in objType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}