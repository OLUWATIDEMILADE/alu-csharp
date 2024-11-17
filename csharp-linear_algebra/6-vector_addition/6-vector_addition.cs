using System;

/// <summary>
/// Provides mathematical operations for vectors.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors together.
    /// </summary>
    /// <param name="vector1">The first vector to add. Must be 2D or 3D.</param>
    /// <param name="vector2">The second vector to add. Must be 2D or 3D.</param>
    /// <returns>
    /// The resulting vector from adding vector1 and vector2.
    /// Returns a vector containing -1 if the vectors are invalid or incompatible.
    /// </returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        // Check if vectors are null
        if (vector1 == null || vector2 == null)
            return new double[] { -1 };

        // Check if vectors are same size and either 2D or 3D
        if (vector1.Length != vector2.Length || 
            (vector1.Length != 2 && vector1.Length != 3))
            return new double[] { -1 };

        // Create result vector of same size
        double[] result = new double[vector1.Length];

        // Add corresponding components
        for (int i = 0; i < vector1.Length; i++)
        {
            result[i] = vector1[i] + vector2[i];
        }

        return result;
    }
}