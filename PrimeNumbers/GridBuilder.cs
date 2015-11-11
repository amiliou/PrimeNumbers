using System;

namespace PrimeNumbers
{
    public class GridBuilder
    {
        public static int[,] Build(int[] primes)
        {
            var dimension = primes.Length + 1;
            var grid = new int[dimension, dimension];

            for (var i = 0; i < primes.Length; i++)
            {
                grid[0, i+1] = primes[i];
                grid[i+1, 0] = primes[i];
            }

            return grid;
        }
    }
}