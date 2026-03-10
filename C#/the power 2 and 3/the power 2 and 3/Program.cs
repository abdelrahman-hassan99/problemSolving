using System;

namespace the_power_2_and_3
{
    internal class Program
    {
        static int CheckPower(int number)
        {
            if (number < 1)
                return -1;

            // Check for power of 2
            if ((number & (number - 1)) == 0)
                return 1;

            // Check for power of 3
            int temp = number;
            while (temp % 3 == 0)
            {
                temp /= 3;
            }
            if (temp == 1)
                return 0;

            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPower(8));    // Output: 1 (2^3)
            Console.WriteLine(CheckPower(27));   // Output: 0 (3^3)
            Console.WriteLine(CheckPower(10));   // Output: -1
        }
    }
}
