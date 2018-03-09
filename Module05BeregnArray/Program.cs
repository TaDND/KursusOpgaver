using System;

namespace Module05BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] test = { 10, 7, 6, 3, 1, 50, 3 };
            Resultat res = BeregnOgSorterArray(test);
            Console.WriteLine("Sum: "+res.sum);
            Console.WriteLine("Gennemsnit. " + res.gennemsnit.ToString());

            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        static Resultat BeregnOgSorterArray (int[] array)
        {
            Resultat res = new Resultat();

            for (int i = 0; i < array.Length; i++)
            {
                res.sum += array[i];
            }
            res.gennemsnit = res.sum / array.Length;

            Array.Sort(array);
            return res;
        }

        struct Resultat
        {
            public double sum;
            public double gennemsnit;
        }
    }
}
