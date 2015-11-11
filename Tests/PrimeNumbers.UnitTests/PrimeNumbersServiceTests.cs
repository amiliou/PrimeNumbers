using Moq;
using NUnit.Framework;

namespace PrimeNumbers.UnitTests
{
    [TestFixture]
    public class PrimeNumbersServiceTests
    {
        private PrimeNumbersService _primeNumbersService;
        private Mock<IGridBuilder> _gridBuilder;
        private Mock<IPrimeNumberGenerator> _primeNumberGenerator;
        

        [Test]
        public void Should_call_generator_and_grid_builder()
        {
            _gridBuilder = new Mock<IGridBuilder>();
            _primeNumberGenerator = new Mock<IPrimeNumberGenerator>();
            _primeNumbersService = new PrimeNumbersService(_primeNumberGenerator.Object, _gridBuilder.Object);

            _primeNumbersService.ConsoleOutputPrimeNumbersGrid(5);

            _gridBuilder.Verify(x => x.Build(It.IsAny<int[]>()), Times.Once);
            _primeNumberGenerator.Verify(x => x.Generate(It.IsAny<int>()), Times.Once);

        }
    }
}
