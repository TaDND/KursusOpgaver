using System;

namespace Module05Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {

            T�ller(1);
            Console.WriteLine("F�rdig");

            

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static void T�ller (int fra)
        {
            Console.WriteLine(fra);
            fra++;
            if (fra <= 10)
                T�ller(fra);
        }
    }
}
