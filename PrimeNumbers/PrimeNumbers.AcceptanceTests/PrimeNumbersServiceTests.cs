using NUnit.Framework;

namespace PrimeNumbers.AcceptanceTests
{
    [TestFixture]
    public class PrimeNumbersServiceTests
    {
        private PrimeNumbersService _primeNumbersService;

        [Test]
        public void Should_console_output_the_primes()
        {
            _primeNumbersService = new PrimeNumbersService(new PrimeNumberGenerator(new DivisorsLocator()), new GridBuilder());
            
            _primeNumbersService.ConsoleOutputPrimeNumbersGrid(105);

        }
    }
}
