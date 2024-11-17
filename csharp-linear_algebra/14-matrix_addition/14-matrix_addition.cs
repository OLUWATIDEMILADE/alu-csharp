using System;

/// <summary>
/// Provides mathematical operations for matrices.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Adds two matrices of the same size.
    /// </summary>
    /// <param name="matrix1">First matrix (must be 2D or 3D).</param>
    /// <param name="matrix2">Second matrix (must be 2D or 3D).</param>
    /// <returns>
    /// Returns the resulting matrix from adding the two matrices.
    /// Returns a matrix containing -1 if matrices are not the same size or not 2D/3D matrices.
    /// </returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices are null
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };

        // Get dimensions of matrices
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if matrices are the same size
        if (rows1 != rows2 || cols1 != cols2)
            return new double[,] { { -1 } };

        // Check if matrices are 2D or 3D
        if (!((rows1 == 2 && cols1 == 2) || (rows1 == 3 && cols1 == 3)))
            return new double[,] { { -1 } };

        // Create result matrix
        double[,] result = new double[rows1, cols1];

        // Add matrices
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols1; j++)
            {
                result[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        return result;
    }
}