// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//var i = 0;
//start:
//if (i <= 5)
//{
//    Console.Write(i + " ");
//    i++;
//    goto start;
//}
//var input = 0.44m;
//var result =AsPersantagDecimal(input);
//Console.WriteLine(result);

//static decimal AsPersantagDecimal(decimal amount)
//{
//    return amount * 100;
//}

//var name = "issam";
//char[] letter = name.ToCharArray();
//foreach (char c in letter)
//{
//    int ascii=Convert.ToInt32(c);
//    var output=$"{c}:ascii{ascii}";
//    Console.WriteLine(output);
//}

//for (int i = 0; i < 10; i++)
//{
//    if (i == 5)
//    {
//        Console.WriteLine(i);

//        continue;
//    }
//}
//Console.ReadLine();

Console.WriteLine("enter number of rows for matrix A");
int rowA = int.Parse(Console.ReadLine());
Console.WriteLine("enter number of col for matrix A");
int colA = int.Parse(Console.ReadLine());
Console.WriteLine("enter number of rows for matrix B");
int rowb = int.Parse(Console.ReadLine());
Console.WriteLine("enter number of col for matrix B");
int colb = int.Parse(Console.ReadLine());

int[,] A = new int[rowA, colA];
int[,] B = new int[rowb, colb];
int[,] result = new int[rowA, colb];

Console.WriteLine("\n enter element for matrix A");

for (int i = 0; i < rowA; i++)
{
    for (int j = 0; j < colA; j++)
    {
        Console.WriteLine($"A[{i},{j}]");
        A[i, j] = int.Parse(Console.ReadLine());
    }
}
Console.WriteLine("\n Enter element for matrix B");

for (int i = 0; i < rowb; i++)
{
    for (int j = 0; j < colb; j++)
    {
        Console.WriteLine($"B[{i},{j}]");
        B[i, j] = int.Parse(Console.ReadLine());
    }
}

if (colA != rowb)
{
    Console.WriteLine(" \n error");
}
else
{
    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < colb; j++)
        {
            result[i, j] = 0;
            for (int k = 0; k < colA; k++)
            {
                result[i, j] += A[i, k] * B[k, j];
            }
        }
    }

    Console.WriteLine("Result matrix");

    for (int i = 0; i < rowA; i++)
    {
        for (int j = 0; j < colb; j++)
        {
            Console.Write(result[i, j] + "\t");
        }
        Console.WriteLine(" \n ");
    }
}