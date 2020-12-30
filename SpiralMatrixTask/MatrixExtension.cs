using System;

#pragma warning disable CA1814
#pragma warning disable S2368

namespace SpiralMatrixTask
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size <= 0)
            {
                throw new ArgumentException("Thrown when matrix size less or equal zero.");
            }

            int[,] result = new int[size, size];

            int pos = 1;
            int count = size;
            int value = -size;
            int sum = -1;

            while (count > 0)
            {
                value = -1 * value / size;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    result[sum / size, sum % size] = pos++;
                }

                value *= size;
                count--;
                for (int i = 0; i < count; i++)
                {
                    sum += value;
                    result[sum / size, sum % size] = pos++;
                }
            }

            return result;
        }
    }
}
