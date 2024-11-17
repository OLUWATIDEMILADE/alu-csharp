/// <summary>
/// A class containing utility methods for type checking.
/// </summary>
public class Obj
{
    /// <summary>
    /// Determines whether the specified object is of type integer.
    /// </summary>
    /// <param name="obj">The object to check.</param>
    /// <returns>True if the object is of type integer; otherwise, False.</returns>
    public static bool IsOfTypeInt(object obj)
    {
        return obj is int;
    }
}
