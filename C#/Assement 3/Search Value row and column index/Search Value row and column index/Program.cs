using System;

namespace Search_Value_row_and_column_index
{
    internal class Program
    {
        static string searchvalue(int[][] jaggedArr,int tagget)
        {
            for (int i = 0; i < jaggedArr.Length; i++)
            {
                for(int j = 0; j < jaggedArr[i].Length; j++)
                {
                    if(jaggedArr[i][j] == tagget)
                    {
                        return $"Found a row {i} , col {j}";
                    }
                }
            }
            return "Not found";
        }
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[][]
            {
           new int[] { 1, 2, 3 },
           new int[] { 4, 5, 6 },
           new int[] { 7, 8, }
            };
            Console.WriteLine("enter the number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine(searchvalue(jaggedArr,x));
        }
    }
}
