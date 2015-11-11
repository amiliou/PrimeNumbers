using System;

namespace PrimeNumbers
{
    public class GridBuilder
    {
        public static int[,] Build(int[] primes)
        {
            var dimension = primes.Length + 1;
            var grid = new int[dimension, dimension];

            FillPrimesInFirstRowAndColumn(primes, grid);
            FillMultiplicationResultsBetweenFirstRowAndColumn(primes, grid);

            return grid;
        }

        private static void FillMultiplicationResultsBetweenFirstRowAndColumn(int[] primes, int[,] grid)
        {
            for (var i = 1; i <= primes.Length && i < 10; i++)
            {
                for (var j = 1; j <= primes.Length && j < 10; j++)
                {
                    grid[i, j] = grid[0, i] * grid[j, 0];
                }
            }
        }

        private static void FillPrimesInFirstRowAndColumn(int[] primes, int[,] grid)
        {
            for (var i = 0; i < primes.Length; i++)
            {
                grid[0, i + 1] = primes[i];
                grid[i + 1, 0] = primes[i];
            }
        }
    }
}