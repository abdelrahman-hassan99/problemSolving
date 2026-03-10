using System;

public class Program
{
    public static void addValue(ref int[] array, ref int size, int value, int position)
    {
        if (position < 0 || position > size )
        {
            Console.WriteLine("invalid");
            return;
        }

        for (int i = size; i > position; i--)
        {
            array[i] = array[i - 1];
        }

        array[position] = value;

        size++;

        Console.Write("The matrix after modification:");


        Console.Write(string.Join(" , ", array));

    }

    public static void Main()
    {
        Console.Write("Enter the number of array elements: ");
        int size = int.Parse(Console.ReadLine());

        int[] array = new int[size + 1];

        Console.WriteLine("Enter the elements of the array:");
        for (int i = 0; i < size; i++)
        {
            Console.Write($"element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("Enter the value you want to enter.: ");
        int value = int.Parse(Console.ReadLine());

        Console.Write($"Enter the location where you want to enter the value (from 0 to {size}) :  ");
        int position = int.Parse(Console.ReadLine());

        addValue(ref array, ref size, value, position);



        


    }
}
