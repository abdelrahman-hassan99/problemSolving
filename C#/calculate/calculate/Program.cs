using System;

namespace calculate
{
    class Program
    {
        static string Calculate(double num1, double num2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return (num1 + num2).ToString();

                case '-':
                    return (num1 - num2).ToString();

                case '*':
                    return (num1 * num2).ToString();

                case '/':
                    if (num2 == 0)
                        return "Error: Division by zero!";
                    return (num1 / num2).ToString();

                default:
                    return "Error: Invalid operation. Use +, -, *, or /.";
            }
        }

        static void Main()
        {
            Console.WriteLine(Calculate(10, 5, '+')); // Output: 15
            Console.WriteLine(Calculate(10, 5, '-')); // Output: 5
            Console.WriteLine(Calculate(10, 5, '*')); // Output: 50
            Console.WriteLine(Calculate(10, 5, '/')); // Output: 2
            Console.WriteLine(Calculate(10, 0, '/')); // Output: Error: Division by zero!
            Console.WriteLine(Calculate(10, 5, '%')); // Output: Error: Invalid operation...
        }
    }
}
