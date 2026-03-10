using System;

namespace print_ascii_number_of_any_character
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 4 - write a program to print ascii number of any character
            Console.WriteLine("Enter you character ");
            char input = char.Parse(Console.ReadLine());
            Console.WriteLine($"{input}:{(int)input}");
            //Console.ReadKey();
        }
    }
}
