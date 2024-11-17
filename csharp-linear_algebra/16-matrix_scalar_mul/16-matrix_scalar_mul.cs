using System;

/// <summary>
/// Provides mathematical operations for matrices.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar value.
    /// </summary>
    /// <param name="matrix">The matrix to multiply (must be 2D or 3D).</param>
    /// <param name="scalar">The scalar value to multiply the matrix by.</param>
    /// <returns>
    /// Returns the resulting matrix from multiplying the matrix by the scalar.
    /// Returns a matrix containing -1 if the matrix is not 2D or 3D.
    /// </returns>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        // Check if matrix is null
        if (matrix == null)
            return new double[,] { { -1 } };

        // Get dimensions of matrix
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Check if matrix is 2D or 3D
        if (!((rows == 2 && cols == 2) || (rows == 3 && cols == 3)))
            return new double[,] { { -1 } };

        // Create result matrix
        double[,] result = new double[rows, cols];

        // Multiply matrix by scalar
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                result[i, j] = matrix[i, j] * scalar;
            }
        }

        return result;
    }
}