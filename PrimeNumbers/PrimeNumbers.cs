
using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            int desiredNumberOfPrimes;
            Console.WriteLine("Please provide a whole number > 0 for primes generation: ");
            if (int.TryParse(Console.ReadLine(), out desiredNumberOfPrimes))
            {
                if (desiredNumberOfPrimes > 0)
                {
                    var primeNumberService = new PrimeNumbersService(new PrimeNumberGenerator(new DivisorsLocator()), new GridBuilder());
                    primeNumberService.ConsoleOutputPrimeNumbersGrid(desiredNumberOfPrimes);
                }
                else
                    Console.WriteLine("You didn't provide a number > 0.");
            }
            else

                Console.WriteLine("You didn't provide a whole number.");

            Console.ReadKey();
        }
    }
}
