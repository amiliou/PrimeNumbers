using System;

namespace PrimeNumbers
{
    public class GridBuilder : IGridBuilder
    {
        public int[][] Build(int[] primes)
        {
            int[][] grid = ConstructGridWithDimension(primes.Length + 1);

            FillPrimesInFirstRowAndColumn(primes, grid);
            FillMultiplicationResultsBetweenFirstRowAndColumn(primes, grid);

            return grid;
        }

        private static int[][] ConstructGridWithDimension(int dimension)
        {
            var grid = new int[dimension][];

            for (var i = 0; i < dimension; i++)
                grid[i] = new int[dimension];

            return grid;
        }

        private static void FillPrimesInFirstRowAndColumn(int[] primes, int[][] grid)
        {
            for (var i = 0; i < primes.Length; i++)
            {
                grid[0][i + 1] = primes[i];
                grid[i + 1][0] = primes[i];
            }
        }

        private static void FillMultiplicationResultsBetweenFirstRowAndColumn(int[] primes, int[][] grid)
        {
            for (var i = 1; i <= primes.Length && i <= 10; i++)
            {
                for (var j = 1; j <= primes.Length && j <= 10; j++)
                {
                    grid[i][j] = grid[0][i] * grid[j][0];
                }
            }
        }

    }
}