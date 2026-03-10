using System;

namespace bybble_sort_algorithm
{
    internal class Program
    {
        public static void BubbleSortDescending(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n ; i++)
            {
                for (int j = i+1 ; j < n ; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            
        }
        static void Main(string[] args)
        {
            Console.Write("enter the total element: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("enter the element:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"elment number {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Sorted in descending order: " + string.Join(", ", arr));


            BubbleSortDescending(arr);

            Console.WriteLine("Sorted in descending order: " + string.Join(", ", arr));
        }
    }
}
