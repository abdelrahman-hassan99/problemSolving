using System;

namespace computes_the_nth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A1 = 1;        // أول حد
            int d = 2;         // الفرق المشترك

            Console.WriteLine("enter the number");
            int n =int.Parse(Console.ReadLine());

            int An = A1 + (n - 1) * d;

            Console.WriteLine($"The {n}th term is: " + An);
        }
    }
}
