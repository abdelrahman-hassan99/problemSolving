using System;

namespace reverse_array
{
    internal class Program
    {
        public static int ReverseArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                // Swap elements
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;

                start++;
                end--;
            }
            return 0;
           
        }
        static void Main(string[] args)
        {
            Console.Write("enter the number of array: ");
            int numElements = int.Parse(Console.ReadLine());

            int[] arr = new int[numElements];

            for (int i = 0; i < numElements; i++)
            {
                Console.Write($"enter the index numbers {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            //int[] numbers = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array: " + string.Join(", ", arr));

            ReverseArray(arr);

            Console.WriteLine("Reversed array: " + string.Join(", ", arr));
        }
    }
}
