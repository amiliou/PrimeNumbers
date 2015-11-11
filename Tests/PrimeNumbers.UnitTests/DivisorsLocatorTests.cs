using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class DivisorsLocatorTests
    {
        [Test]
        [TestCase(9)]
        [TestCase(27)]
        [TestCase(447)]
        public void Should_return_true_if_number_is_evenly_divisible(int nonPrime)
        {
            var result = new DivisorsLocator().DoesAnyNumberEvenlyDividePrimeNumber(nonPrime);
            Assert.That(result, Is.True);
        }

        [Test]
        [TestCase(17)]
        [TestCase(167)]
        [TestCase(541)]
        public void Should_return_false_if_number_is_not_evenly_divisible(int prime)
        {
            var result = new DivisorsLocator().DoesAnyNumberEvenlyDividePrimeNumber(prime);
            Assert.That(result, Is.False);
        }
    }
}
