using System;

namespace FIRST_occurrence
{
    internal class Program
    {
        static int FirstIndexOf(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 4, 4 ,4};
            int target = 4;

            int index = FirstIndexOf(array, target);
            Console.WriteLine(index);  // Output: 3
        }
        //static void Main(string[] args)
        //{

        //}
    }
}
