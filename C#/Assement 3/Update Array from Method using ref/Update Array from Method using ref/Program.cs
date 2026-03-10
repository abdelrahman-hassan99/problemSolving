using System;

namespace Update_Array_from_Method_using_ref
{
    internal class Program
    {
        static void InitializeArray(ref int[] arr)
        {
            arr =new int[5];

            for (int i = 0; i < arr.Length; i++) 
            {
            arr[i] = 100;
            }
        }
        static void Main(string[] args)
        {
            int[] array = null;
            InitializeArray(ref array);

            Console.WriteLine("convet arry to number 100 : =>  \n"+string.Join(" ," , array));
        }
    }
}
