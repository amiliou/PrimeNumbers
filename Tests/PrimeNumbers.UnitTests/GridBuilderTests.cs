

using NUnit.Framework;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class GridBuilderTests
    {
        [Test]
        public void Should_get_a_N_plus_1_x_N_plus_1_grid_with_only_the_primes()
        {
            var primes = new int[4] { 2, 3, 5, 7 };
            var expectedGrid = new []
            {
                new [] {0, 2, 3, 5, 7},
                new [] {2, 0, 0, 0, 0},
                new [] {3, 0, 0, 0, 0},
                new [] {5, 0, 0, 0, 0},
                new [] {7, 0, 0, 0, 0}
            };

            var actualGrid = GridBuilder.Build(primes);

            Assert.That(actualGrid[0][1], Is.EqualTo(2));
            Assert.That(actualGrid[1][0], Is.EqualTo(2));
            Assert.That(actualGrid[0][4], Is.EqualTo(7));
            Assert.That(actualGrid[4][0], Is.EqualTo(7));
        }

        [Test]
        public void Should_get_a_N_plus_1_x_N_plus_1_grid_with_primes_and_multiplications()
        {
            var primes = new int[4] { 2, 3, 5, 7 };
            var expectedGrid = new int[5][]
            {
                new [] {0, 2,  3,  5,  7},
                new [] {2, 4,  6,  10, 14},
                new [] {3, 6,  9,  15, 21},
                new [] {5, 10, 15, 25, 35},
                new [] {7, 14, 21, 35, 49}
            };

            var actualGrid = GridBuilder.Build(primes);

            Assert.That(actualGrid, Is.EqualTo(expectedGrid));           
        }
    }
}
