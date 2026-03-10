using System;

namespace Default_Constructor
{
    internal class Program
    {
        public class Car
        {
            public string make { get; set; }
            public string model { get; set; }
            public int year { get; set; }

            public Car()
            {
                make = "honad";
                model = "civic";
                year = 2010;
                
            }
            public void printInfo()
            {
                Console.WriteLine($"make : {make} and model :{model} and year :{year} ");
            } 
        }
        static void Main(string[] args)
        {
            Car car =new Car();
            car.printInfo();
        }
    }
}
