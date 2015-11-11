using System;

namespace PrimeNumbers
{
    public class PrimeNumbersService
    {
        private IPrimeNumberGenerator _primeNumberGenerator;
        private IGridBuilder _gridBuilder;

        public PrimeNumbersService(IPrimeNumberGenerator primeNumberGenerator, IGridBuilder gridBuilder)
        {
            _primeNumberGenerator = primeNumberGenerator;
            _gridBuilder = gridBuilder;
        }

        public void ConsoleOutputPrimeNumbersGrid(int desiredNumberOfPrimes)
        {
            var primes = _primeNumberGenerator.Generate(desiredNumberOfPrimes);
            var grid = _gridBuilder.Build(primes);

        }
    }
}