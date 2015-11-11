using System.Collections.Generic;

namespace PrimeNumbers
{
    public interface IPrimeNumberGenerator
    {
        int[] Generate(int desiredNumberOfPrimes);
    }
}