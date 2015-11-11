

using NUnit.Framework;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class GridBuilderTests
    {
        [Test]
        public void Should_get_a_N_plus_1_x_N_plus_1_grid()
        {
            var primes = new int[4] { 2, 3, 5, 7 };
            var expectedGrid = new int[5, 5]
            {
                {0, 2, 3, 5, 7},
                {2, 0, 0, 0, 0},
                {3, 0, 0, 0, 0},
                {5, 0, 0, 0, 0},
                {7, 0, 0, 0, 0},
            };

            var actualGrid = GridBuilder.Build(primes);

            Assert.That(actualGrid, Is.EquivalentTo(expectedGrid));
        }
    }
}
