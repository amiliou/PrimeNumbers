using Moq;
using NUnit.Framework;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        private PrimeNumberGenerator _primeNumberGenerator;
        private Mock<IDivisorsLocator> _divisorsLocator;

        [SetUp]
        public void SetUp()
        {
            _divisorsLocator = new Mock<IDivisorsLocator>();
            _primeNumberGenerator = new PrimeNumberGenerator(_divisorsLocator.Object);
        }

        [Test]
        public void Should_return_only_2_as_a_prime_for_n_equal_to_1()
        {
            var desiredNumberOfPrimes = 1;
            
            var primes = _primeNumberGenerator.Generate(desiredNumberOfPrimes);

            Assert.That(primes.Length, Is.EqualTo(desiredNumberOfPrimes));
            Assert.That(primes[0], Is.EqualTo(2));
        }

        [Test]
        [TestCase(2, new int[2] { 2, 3 })]
        [TestCase(5, new int[5] { 2, 3, 5, 7, 11})]
        public void Should_return_N_primes(int desiredNumberOfPrimes, int[] expectedPrimes)
        {
            _divisorsLocator
                .Setup(x => x.DoesAnyNumberEvenlyDividePrimeNumber(9))
                .Returns(true);

            var actualPrimes = _primeNumberGenerator.Generate(desiredNumberOfPrimes);

            Assert.That(actualPrimes.Length, Is.EqualTo(desiredNumberOfPrimes));
            Assert.That(actualPrimes, Is.EquivalentTo(expectedPrimes));
        }
    }
}
