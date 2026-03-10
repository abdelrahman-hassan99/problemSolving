using System;
using System.ComponentModel;
using Microsoft.VisualBasic;

namespace Assement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 - write a program to print area of circle

            Console.Write("Enter Radius: ");
            double r = Convert.ToDouble(Console.ReadLine());
            //double Area = Math.PI * r * 2; 
            double Area = 3.14 * r * r;

            Console.WriteLine("Area of circle: " + Area);

            ////2 -  write a porgram to print + , - , / , *of 2 numbers


            //var x = 4;
            //var y = 2;
             
            //Console.WriteLine($" x * y  = {x * y} ");
            //Console.WriteLine($" x / y  = {x / y} ");
            //Console.WriteLine($" x + y  = {x + y} ");
            //Console.WriteLine($" x - y  = {x - y} ");

            //// 3 - update in problem no 2 , Take 2 numbers And Operator(+,/, -, *), then Print Result

            //Console.WriteLine("Enter you number : z");
            //int z = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter you number : v");

            //int v = int.Parse(Console.ReadLine());

            //Console.WriteLine($" z * v  = {z * v} ");
            //Console.WriteLine($" z / v  = {z / v} ");
            //Console.WriteLine($" z + v  = {z + v} ");
            //Console.WriteLine($" z - v  = {z - v} ");

            //// 4 - write a program to print ascii number of any character
            //Console.WriteLine("Enter you character ");
            //char input =char.Parse(Console.ReadLine());
            //Console.WriteLine($"{input}:{(int)input}");//explict casting

            ////Console.ReadKey();

        }
    }
}
