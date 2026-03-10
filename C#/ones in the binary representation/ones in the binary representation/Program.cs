using System;

namespace ones_in_the_binary_representation
{
    internal class Program
    {
        public static int CountOnes(int number)
        {
            int count = 0;
            uint n = (uint)number; // نحول الرقم إلى unsigned لتفادي المشاكل مع الأرقام السالبة

            while (n != 0)
            {
                n &= (n - 1); // نحذف أقل بت 1 مفعّل
                count++;
            }

            return count;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(CountOnes(9));   // الناتج: 2  (لأن 9 = 1001)
            Console.WriteLine(CountOnes(-1));  // الناتج: 32 (لأن -1 في تمثيل 32 بت = 32 ones)
        }
    }
}
