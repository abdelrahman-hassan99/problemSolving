using System;

class Program
{
    static void FindMinMax(int[] arr, ref int min, ref int max)
    {
        min = arr[0];
        max = arr[0];

        for (int i = 1 ; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i]; 
            }
            if (arr[i] > max)
            {
                max = arr[i]; 
            }
        }
    }

    static void Main()
    {
        int[] numbers = { 4, 8, 2, 10, 1 };

        int min = 0; 
        int max = 0;

        FindMinMax(numbers, ref min, ref max);

        Console.WriteLine($"Min: {min}, Max: {max}");
    }
}
