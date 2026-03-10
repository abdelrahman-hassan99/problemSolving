using System;


namespace Positive_or_Negative_Or_zero_using_if_.else_statement_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Get a number from a user &checking if it is Positive or Negative Or zero using if ...else statement.
            Console.WriteLine("Enter your Number");
            int num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                Console.WriteLine("number is positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("number is nagative");
            }
            else
            {
                Console.WriteLine("number is zero");
            }
        }
    }
}
