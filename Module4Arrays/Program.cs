using System;

namespace Module4Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] l�n = new double[6];
            Random rnd = new Random();

            double total = 0;
            for (int i = 0; i < l�n.Length; i++)
            {
                l�n[i] = rnd.Next(15000, 150000);
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
