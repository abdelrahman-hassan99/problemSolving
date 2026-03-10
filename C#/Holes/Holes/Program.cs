// See https://aka.ms/new-console-template for more information


class HoleCounter
{
    public static int CountHoles(string numStr)
    {
        int count = 0;

        foreach (char digit in numStr)
        {
            switch (digit)
            {
                case '0': count++; break;
                case '6': count++; break;
                case '8': count += 2; break;
                case '9': count++; break;
                default: break;
            }
        }

        return count;
    }

    static void Main()
    {
        Console.Write("Enter the number: ");
        string input = Console.ReadLine();
        int holes = CountHoles(input);
        Console.WriteLine("The Number Of The Holes = " + holes);
    }
}



