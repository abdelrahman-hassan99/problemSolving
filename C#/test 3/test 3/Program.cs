// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//public class HoleCounter
//{
//    public static int CountHoles(int num)
//    {
//        // مصفوفة تمثل عدد الفتحات في كل رقم من 0 إلى 9
//        int[] holes = new int[] { 1, 0, 0, 0, 1, 0, 1, 0, 2, 1 };

//        int totalHoles = 0;

//        // نحول الرقم إلى قيمة موجبة للتعامل مع الأرقام السالبة
//        num = Math.Abs(num);

//        // نحول الرقم إلى سلسلة حتى نمر على كل رقم فيه
//        foreach (char digit in num.ToString())
//        {
//            // نحصل على الرقم الصحيح من الحرف ثم نستخدمه للوصول لعدد الفتحات
//            totalHoles += holes[digit - '0'];
//        }

//        return totalHoles;
//    }

//    // مثال للتجربة
//    public static void Main()
//    {
//        Console.WriteLine("Enter the number of holes");
//        int number = int.Parse(Console.ReadLine());
//        int holesCount = CountHoles(number);
//        Console.WriteLine($"Total holes in {number}: {holesCount}");
//    }
//}


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