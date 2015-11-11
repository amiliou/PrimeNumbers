using System;

namespace PrimeNumbers
{
    public class DivisorsLocator : IDivisorsLocator
    {
        public bool DoesAnyNumberEvenlyDividePrimeNumber(int potentialPrime)
        {
            int maxPotentialDivisor = (int)Math.Sqrt(potentialPrime);

            for (var i = 2; i <= maxPotentialDivisor; i++)
            {
                if (potentialPrime % i == 0)
                    return true;
            }
            return false;
        }
    }
}