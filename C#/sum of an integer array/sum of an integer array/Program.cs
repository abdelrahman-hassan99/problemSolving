using System;

namespace sum_of_an_integer_array
{
     class Program
    {
        public static int total(int[] array,int numberOfSum)
        {
            int sum = 0;
            for (int i = 0; i < numberOfSum; i++)
            {
                sum += array[i];
            }
            return sum;
        
        }
        static void Main()
        {
            Console.Write("enter the number of array: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] array = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"enter the index numbers {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, };
            int numberelement = array.Length;
            int result = total(array, numberelement);
            Console.WriteLine(" the tolal of number" + result);
        }
    }
}
