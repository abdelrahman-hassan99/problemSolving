using System;

namespace Fibonacci
{
    using System;

    class Program
    {
        static int FibonacciIterative(int n)
        {
            if (n <= 1)
                return n;

            int a = 0, b = 1, result = 0;

            for (int i = 2; i <= n; i++)
            {
                result = a + b;
                a = b;
                b = result;
            }

            return b;
        }

        static void Main()
        {
            int n = 7;
            Console.WriteLine($"Fibonacci({n}) = {FibonacciIterative(n)}");
        }
    }

}
