using System;

namespace distinct_and__repeated_
{
    internal class Program
    {
        public static bool repeated(string arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length ; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        return false;
                    }
                }             
            }
            return true;

        }
        static void Main()
        {
            Console.WriteLine("Enter the  number words");
            int num= int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++) 
            {    
                    Console.WriteLine($"Enter the {i} word");
                    string test1 = Console.ReadLine();
                    Console.WriteLine(repeated(test1));
            }
        }
    }
}
