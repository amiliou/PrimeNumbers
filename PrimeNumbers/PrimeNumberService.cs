using System;

namespace PrimeNumbers
{
    public class PrimeNumbersService
    {
        private IPrimeNumberGenerator _primeNumberGenerator;
        private IGridBuilder _gridBuilder;

        public PrimeNumbersService(IPrimeNumberGenerator primeNumberGenerator, IGridBuilder gridBuilder)
        {
            _primeNumberGenerator = primeNumberGenerator;
            _gridBuilder = gridBuilder;
        }

        public void ConsoleOutputPrimeNumbersGrid(int desiredNumberOfPrimes)
        {
            var primes = _primeNumberGenerator.Generate(desiredNumberOfPrimes);
            var grid = _gridBuilder.Build(primes);

            ConsoleOutputGrid(grid);
        }

        private void ConsoleOutputGrid(int[][] grid)
        {
            var dimension = grid[0].Length;

            int widestNumber = GetWidestNumber(grid, dimension);

            var numberOfVerticalLines = dimension + 1;

            var widthOfAllColumnsWithWidthOfWidestNumber = dimension * widestNumber;

            var tableWidth = widthOfAllColumnsWithWidthOfWidestNumber + numberOfVerticalLines;

            for (var i = 0; i < dimension; i++)
            {
                PrintRow(tableWidth, grid[i]);
                PrintLine(tableWidth);
            }
        }

        private static int GetWidestNumber(int[][] grid, int dimension)
        {
            var widestNumber = grid[dimension - 1][dimension - 1].ToString().Length;
            
            if (dimension > 10)
                widestNumber = grid[10][10].ToString().Length;

            return widestNumber;
        }

        private static void PrintRow(int tableWidth, int[] numbersOfRow)
        {
            var columnWidth = (tableWidth - numbersOfRow.Length) / numbersOfRow.Length;
            var row = "|";

            foreach (var number in numbersOfRow)
            {
                row += AlignInColumnCentre(number, columnWidth) + "|";
            }

            Console.WriteLine(row);
        }

        private static string AlignInColumnCentre(int number, int width)
        {
            if (number == 0)
                return new string(' ', width);

            var numberText = number.ToString();
            return numberText.PadRight(width - (width - numberText.Length) / 2).PadLeft(width);
        }

        private static void PrintLine(int tableWidth)
        {
            Console.WriteLine(new string('-', tableWidth));
        }
    }
}