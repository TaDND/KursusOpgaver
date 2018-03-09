using System;

namespace Module4Arrays
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] løn = new double[6];
            Random rnd = new Random();

            double total = 0;
            for (int i = 0; i < løn.Length; i++)
            {
                løn[i] = rnd.Next(15000, 150000);
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
