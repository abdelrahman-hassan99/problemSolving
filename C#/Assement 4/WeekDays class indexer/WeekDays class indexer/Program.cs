using System;

namespace WeekDays_class_indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            weekday weekDays = new weekday();

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(weekDays[i]);
            }
        }
    }
}
