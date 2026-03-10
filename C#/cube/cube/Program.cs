using System;

namespace cube
{
    using System;

    class Program
    {
        static void PrintCube(double number)
        {
            double cube = number * number * number;
            Console.WriteLine($"The cube of {number} is {cube}");
        }

        static void Main()
        {
            PrintCube(3);    // Output: The cube of 3 is 27
            PrintCube(2.5);  // Output: The cube of 2.5 is 15.625
        }
    }

}
