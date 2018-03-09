using System;

namespace Module05Overload
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Beregn (1,2));
            Console.WriteLine(Beregn(1, 2, 3));
            Console.WriteLine(Beregn(1, 2, 3, 4));
            

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static int Beregn (int a, int b)
        {
            return a + b;
        }
        static int Beregn (int a, int b, int c)
        {
            return c + Beregn(a, b);
        }
        static int Beregn(int a, int b, int c, int d)
        {
            return d + Beregn(a, b, c);
        }
    }
}
