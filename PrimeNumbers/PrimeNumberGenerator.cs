using System.Collections.Generic;

namespace PrimeNumbers
{
    public class PrimeNumberGenerator : IPrimeNumberGenerator
    {
        private readonly IDivisorsLocator _divisorsLocator;

        public PrimeNumberGenerator(IDivisorsLocator divisorsLocator)
        {
            _divisorsLocator = divisorsLocator;
        }

        public int[] Generate(int desiredNumberOfPrimes)
        {
            var primes = new List<int>();
            primes.Add(2);

            int potentialPrime = 3;
            while (primes.Count < desiredNumberOfPrimes)
            {
                var isDivisible = _divisorsLocator.DoesAnyNumberEvenlyDividePrimeNumber(potentialPrime);
                if (!isDivisible)
                    primes.Add(potentialPrime);

                potentialPrime = GetNextOddNumber(potentialPrime);
            }
          
            return primes.ToArray();
        }

        private static int GetNextOddNumber(int potentialPrime)
        {
            // we only test odd numbers, as even ones aren't primes
            return potentialPrime += 2;
        }
    }
}