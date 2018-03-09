using System;

namespace Module05Rekursion
{
    class Program
    {
        static void Main(string[] args)
        {

            Tæller(1);
            Console.WriteLine("Færdig");

            

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        static void Tæller (int fra)
        {
            Console.WriteLine(fra);
            fra++;
            if (fra <= 10)
                Tæller(fra);
        }
    }
}
