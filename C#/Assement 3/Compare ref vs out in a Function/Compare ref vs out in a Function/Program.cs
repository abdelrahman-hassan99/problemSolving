using System;

namespace Compare_ref_vs_out_in_a_Function
{
    internal class Program
    {
        static void modifyWithRef( ref int x)
        {
            x = x * 5; 
        }

        static void modifyWithOut(out int y)
        {
            y = 20;
        }



        static void Main(string[] args)
        {
            int a = 5;
            int b;
            modifyWithRef( ref a ); 
            modifyWithOut( out b );

            Console.WriteLine($"a after ref : {a}");
            Console.WriteLine($"b after out : {b}");
        }
    }
}
