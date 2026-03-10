using System;

namespace Zeros_between_two_ones
{
    internal class Program
    {
        public static int MaxZerosBetweenOnes(int number)
        {
            string binary = Convert.ToString(number, 2); // نحول الرقم إلى باينري
            int maxZeros = 0;
            int currentZeros = 0;
            bool foundOne = false;

            foreach (char bit in binary)
            {
                if (bit == '1')
                {
                    if (foundOne)
                    {
                        // أغلقنا فجوة بين 1 و 1
                        if (currentZeros > maxZeros)
                            maxZeros = currentZeros;
                    }
                    else
                    {
                        foundOne = true; // أول 1 تم العثور عليه
                    }
                    currentZeros = 0; // نبدأ العد من جديد
                }
                else if (foundOne)
                {
                    currentZeros++; // نعد الأصفار بين 1s فقط
                }
            }

            return maxZeros;
        }
        static void Main(string[] args)
        {
            int number = Convert.ToInt32("10110010001010000011100010000110", 2);
            Console.WriteLine(MaxZerosBetweenOnes(number)); // الناتج: 5
        }
    }
}
