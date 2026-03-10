using System;

namespace prime_number_between_two_number
{
    class Program
    {
        static bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int i = 2; i * i <= number; i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        static void DisplayPrimesBetween(int start, int end)
        {
            Console.WriteLine($"Prime numbers between {start} and {end}:");

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    Console.Write(i + " ");
            }

            Console.WriteLine(); // For newline
        }

        static void Main()
        {
            DisplayPrimesBetween(10, 50); // Example: primes between 10 and 50
        }
    }
}
