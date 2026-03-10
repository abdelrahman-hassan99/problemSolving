using System;

namespace Create_a_jagged_array_with_3_rows
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 1,2 }; 
            jaggedArr[1] = new int[] { 3,4,5,6};  
            jaggedArr[2] = new int[] { 7};

            foreach (int[] row in jaggedArr)
            {
                foreach (int elem in row)
                {
                    Console.Write(elem + " ");
                }
                Console.WriteLine();
            }

        }
    }
}
