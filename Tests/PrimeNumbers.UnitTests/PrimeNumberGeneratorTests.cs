
using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        [Test]
        public void Should_return_only_2_as_a_prime_for_n_equal_to_1()
        {
            var desiredNumberOfPrimes = 1;
            IList<int> primes = PrimeNumberGenerator.Generate(desiredNumberOfPrimes);

            Assert.That(primes.Count, Is.EqualTo(desiredNumberOfPrimes));
            Assert.That(primes[0], Is.EqualTo(2));
        }

        [Test]
        public void Should_return_2_and_3_as_primes_for_n_equal_to_2()
        {
            var desiredNumberOfPrimes = 2;
            IList<int> primes = PrimeNumberGenerator.Generate(desiredNumberOfPrimes);

            Assert.That(primes.Count, Is.EqualTo(desiredNumberOfPrimes));
            Assert.That(primes[0], Is.EqualTo(2));
            Assert.That(primes[1], Is.EqualTo(3));
        }

    }
}
