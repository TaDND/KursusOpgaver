using System;

namespace Module4Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            int[] l�n = new int[6];
            l�n[0] = 50000;
            l�n[1] = 15000;
            l�n[2] = 25000;
            l�n[3] = 120000;
            l�n[4] = 40000;
            l�n[5] = 35000;

            int total = 0;
            for (int i = 0; i < l�n.Length; i++)
            {
                Console.WriteLine(l�n[i]);
                total = total + l�n[i];
            }
            Console.WriteLine();
            Console.WriteLine("Gennemsnit: "+(total/l�n.Length));



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
