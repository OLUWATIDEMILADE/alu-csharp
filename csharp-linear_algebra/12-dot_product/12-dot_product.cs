using System;

/// <summary>
/// Provides mathematical operations for vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    /// <param name="vector1">First vector (must be 2D or 3D).</param>
    /// <param name="vector2">Second vector (must be 2D or 3D).</param>
    /// <returns>
    /// Returns the dot product of the two vectors.
    /// Returns -1 if vectors are not the same size or not 2D/3D vectors.
    /// </returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        // Check if vectors are null
        if (vector1 == null || vector2 == null)
            return -1;

        // Check if vectors are the same size
        if (vector1.Length != vector2.Length)
            return -1;

        // Check if vectors are either 2D or 3D
        if (vector1.Length != 2 && vector1.Length != 3)
            return -1;

        double result = 0;
        
        // Calculate dot product
        for (int i = 0; i < vector1.Length; i++)
        {
            result += vector1[i] * vector2[i];
        }

        return result;
    }
}