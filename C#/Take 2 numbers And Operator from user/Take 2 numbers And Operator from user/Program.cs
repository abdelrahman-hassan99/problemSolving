using System;

namespace Take_2_numbers_And_Operator_from_user
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 3 - update in problem no 2 , Take 2 numbers And Operator(+,/, -, *), then Print Result
            Console.WriteLine("Enter you number : z");
            int z = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter you number : v");
            int v = int.Parse(Console.ReadLine());
            Console.WriteLine($" z * v = {z * v} ");
            Console.WriteLine($" z / v = {z / v} ");
            Console.WriteLine($" z + v = {z + v} ");
            Console.WriteLine($" z - v = {z - v} ");
        }
    }
}
