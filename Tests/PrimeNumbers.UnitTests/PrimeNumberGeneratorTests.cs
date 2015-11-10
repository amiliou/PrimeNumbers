﻿
using NUnit.Framework;
using System.Collections.Generic;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class PrimeNumberGeneratorTests
    {
        private IList<int> first100Primes = new List<int>
        {
            2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97, 101, 103, 107, 109,
            113, 127, 131, 137, 139, 149, 151, 157, 163, 167, 173, 179, 181, 191, 193, 197, 199, 211, 223, 227, 229, 233, 239, 241,
            251, 257, 263, 269, 271, 277, 281, 283, 293, 307, 311, 313, 317, 331, 337, 347, 349, 353, 359, 367, 373, 379, 383, 389,
            397, 401, 409, 419, 421, 431, 433, 439, 443, 449, 457, 461, 463, 467, 479, 487, 491, 499, 503, 509, 521, 523, 541
        };

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
            Assert.That(primes, Is.SubsetOf(first100Primes));

        }

    }
}
