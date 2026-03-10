using System;

namespace write_a_program_to_print_area_of_circle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - write a program to print area of circle
            Console.Write("Enter Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            //double Area = Math.PI * r * r;
            double Area = 3.14 * r * r;
            Console.WriteLine("Area of circle: " + Area);
        }
    }
}
