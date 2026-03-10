using System;

namespace computes_multiplication_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A1 = 1;         // الحد الأول
            int r = 3;          // النسبة المشتركة

            Console.WriteLine("Enter the number");
            int n = int .Parse(Console.ReadLine());

            // حساب الحد العاشر
            int An = A1 * (int)Math.Pow(r, n - 1);

            Console.WriteLine($"The {n}th term is: " + An);
        }
    }
}
