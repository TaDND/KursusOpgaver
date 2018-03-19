using System;
using Teknologisk;

namespace Module08_Arv_Random_
{
    class Program
    {
        static void Main(string[] args)
        {

            UdvidetRandom r = new UdvidetRandom();
            Console.WriteLine(r.NextBool());
            




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class UdvidetRandom : Random
        {
            public bool NextBool()
            {
                return this.Next(1, 1002) < 500;
            }
        }
    }
}