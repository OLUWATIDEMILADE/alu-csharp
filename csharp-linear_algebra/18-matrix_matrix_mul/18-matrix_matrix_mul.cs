using System;

/// <summary>
/// Provides mathematical operations for matrices.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices.
    /// </summary>
    /// <param name="matrix1">First matrix to multiply.</param>
    /// <param name="matrix2">Second matrix to multiply.</param>
    /// <returns>
    /// Returns the resulting matrix from multiplying the two matrices.
    /// Returns a matrix containing -1 if the matrices cannot be multiplied.
    /// </returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        // Check if matrices are null
        if (matrix1 == null || matrix2 == null)
            return new double[,] { { -1 } };

        // Get dimensions of matrices
        int rows1 = matrix1.GetLength(0);
        int cols1 = matrix1.GetLength(1);
        int rows2 = matrix2.GetLength(0);
        int cols2 = matrix2.GetLength(1);

        // Check if matrices can be multiplied
        // Number of columns in first matrix must equal number of rows in second matrix
        if (cols1 != rows2)
            return new double[,] { { -1 } };

        // Create result matrix
        double[,] result = new double[rows1, cols2];

        // Multiply matrices
        for (int i = 0; i < rows1; i++)
        {
            for (int j = 0; j < cols2; j++)
            {
                double sum = 0;
                for (int k = 0; k < cols1; k++)
                {
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                result[i, j] = sum;
            }
        }

        return result;
    }
}