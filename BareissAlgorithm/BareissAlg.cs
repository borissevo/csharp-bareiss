namespace BareissAlgorithm
{
    /// <summary>
    /// Bareiss algorithm implementation.
    /// https://en.wikipedia.org/wiki/Bareiss_algorithm
    /// </summary>
    internal class BareissAlg
    {
        /// <summary>
        /// Computes determinant of the specified matrix.
        /// </summary>
        /// <param name="mat">Matrix which determinant is calculated.</param>
        /// <returns>Matrix determinant</returns>
        internal int Determinant(int[,] mat)
        {
            int numberOfCols = mat.GetLength(1) - 1;
            for (int k = 0; k < numberOfCols; k++)
            {
                Compute(mat, numberOfCols, k);
            }

            return mat[mat.GetLength(0) - 1, numberOfCols];
        }

        /// <summary>
        /// Computes one step of the Bareiss algorithm. 
        /// </summary>
        /// <param name="mat">Matrix which determinant is calculated.</param>
        /// <param name="numberOfColumns">Number of columns in matrix.</param>
        /// <param name="k">Step number</param>
        private void Compute(int[,] mat, int numberOfColumns, int k)
        {
            for (int i = k + 1; i <= numberOfColumns; i++)
            {
                for (int j = k + 1; j <= numberOfColumns; j++)
                {
                    int minEnd = mat[k, k] * mat[i, j];
                    int subtr = mat[i, k] * mat[k, j];
                    int result = (minEnd - subtr) / (k == 0 ? 1 : mat[k - 1, k - 1]);
                    mat[i, j] = result;
                }
            }
        }
    }
}
