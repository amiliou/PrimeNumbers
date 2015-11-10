
using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        [Test]
        public void Should_not_return_any_primes_for_n_equal_to_1()
        {
            IList<int> primes = PrimeNumberGenerator.Generate(1);

            Assert.That(primes.Count, Is.EqualTo(0));
        }

    }
}
