using System;

/// <summary>
/// Provides mathematical operations for vectors.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Multiplies a vector by a scalar value.
    /// </summary>
    /// <param name="vector">The input vector (must be 2D or 3D).</param>
    /// <param name="scalar">The scalar value to multiply the vector by.</param>
    /// <returns>
    /// Returns a new vector where each component is multiplied by the scalar.
    /// Returns a vector containing -1 if the input vector is invalid (not 2D or 3D).
    /// </returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        // Check if vector is null
        if (vector == null)
            return new double[] { -1 };

        // Check if vector is 2D or 3D
        if (vector.Length != 2 && vector.Length != 3)
            return new double[] { -1 };

        // Create result vector of same size
        double[] result = new double[vector.Length];

        // Multiply each component by scalar
        for (int i = 0; i < vector.Length; i++)
        {
            result[i] = vector[i] * scalar;
        }

        return result;
    }
}