using System;

namespace function_to_swap
{
    internal class Program
    {
        public static void SwapArrays(int[] array1, int[] array2)
        {
            if (array1.Length != array2.Length)
            {
                Console.WriteLine("the two matrix is not the same lenght");
                return;
            }

            for (int i = 0; i < array1.Length; i++)
            {
                int temp = array1[i];
                array1[i] = array2[i];
                array2[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3 };
            int[] array2 = { 4, 5, 6 };

            Console.WriteLine("after:");
            Console.WriteLine("array1: " + string.Join(", ", array1));
            Console.WriteLine("array2: " + string.Join(", ", array2));

            SwapArrays(array1, array2);

            Console.WriteLine("\n befor :");
            Console.WriteLine("array1: " + string.Join(", ", array1));
            Console.WriteLine("array2: " + string.Join(", ", array2));

        }
    }
}
