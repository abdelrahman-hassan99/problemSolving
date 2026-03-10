// See https://aka.ms/new-console-template for more information
class program
{
    static void Main(string[] args)
    {
        int[,] input = new int[,]
        {
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },
        { 8, 7, 5, 4, 21, 2, 5, 5 },


        };
        var sduko = new sduko(input);
        Console.WriteLine(sduko[5,5]);
        sduko[5, 5] = 10;
        Console.WriteLine();
    }
}
public class sduko
{
    private int[,] _matrix;
    public int this[int row, int col]
    {
        get
        {
            return _matrix[row, col];
        }
        set
        {
            _matrix[row, col] = value;
        }
    }
    public sduko(int[,] matrix)
    { 
    _matrix = matrix;
    }
}