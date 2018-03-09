using System;

namespace Module4Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] løn = new int[6];
            løn[0] = 50000;
            løn[1] = 15000;
            løn[2] = 25000;
            løn[3] = 120000;
            løn[4] = 40000;
            løn[5] = 35000;

            int total = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                Console.WriteLine(løn[i]);
                total = total + løn[i];
            }
            Console.WriteLine();
            Console.WriteLine("Gennemsnit: "+(total/løn.Length));



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
