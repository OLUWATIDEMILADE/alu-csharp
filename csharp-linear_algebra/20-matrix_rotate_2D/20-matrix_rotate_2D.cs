using System;

/// <summary>
/// Class that provides mathematical operations for matrices.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix by a given angle in radians.
    /// </summary>
    /// <param name="matrix">The square matrix to rotate.</param>
    /// <param name="angle">The angle to rotate by (in radians).</param>
    /// <returns>The rotated matrix, or a matrix containing -1 if the input is invalid.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix == null || matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        int size = matrix.GetLength(0);
        double[,] result = new double[size, size];

        double cos = Math.Round(Math.Cos(angle), 2);
        double sin = Math.Round(Math.Sin(angle), 2);

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                // Apply 2D rotation transformation
                double x = matrix[i, j];
                result[i, j] = Math.Round(x * cos - x * sin, 2);
            }
        }

        return result;
    }
}