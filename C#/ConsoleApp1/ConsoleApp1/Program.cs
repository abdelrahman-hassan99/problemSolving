using System;
using System.Threading.Channels;
namespace CAEvent
{
    class program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> List1 = new int[] {1,2,3,4,5,6,7,8,9};
            PrintNumber(List1, n => n > 6 , () => Console.WriteLine("number > 6 "));

            IEnumerable<decimal> List2 = new decimal[] { 1.2m, 2.3m, 3.5m, 4m, 5m, 6m, 7m, 8m, 9m };
            PrintNumber(List2, n => n > 6.2m, () => Console.WriteLine("number > 6.2m "));


        }
        static void PrintNumber<T>(IEnumerable<T> number, Func<T, bool> filter, Action action)
        {
            action();
            foreach (var n in number)
            {
                if (filter(n))
                {
                    Console.WriteLine(n);
                }
            }
        }

    }

}
