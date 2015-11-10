
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
            IList<int> primes = PrimeNumberGenerator.Generate(1);

            Assert.That(primes.Count, Is.EqualTo(1));
            Assert.That(primes[0], Is.EqualTo(2));
        }

    }
}
