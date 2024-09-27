using System;

class Matrix
{
    public static int[,] Square(int[,] myMatrix)
    {
        // Get the dimensions of the original matrix
        int rows = myMatrix.GetLength(0);
        int columns = myMatrix.GetLength(1);

        // Create a new matrix to store the squared values
        int[,] squaredMatrix = new int[rows, columns];

        // Loop through the original matrix and compute the square of each element
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                squaredMatrix[i, j] = myMatrix[i, j] * myMatrix[i, j];
            }
        }

        // Return the new matrix with squared values
        return squaredMatrix;
    }
}