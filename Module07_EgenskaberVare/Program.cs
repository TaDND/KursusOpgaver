using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_EgenskaberVare
{
    class Program
    {
        static void Main(string[] args)
        {
            Vare v1 = new Vare();

            v1.Navn = "Mælk";
            v1.Pris = 10;
            Console.WriteLine("Prisen inkl. moms på " + v1.Navn + "er " + v1.PrisMedMoms());
            Console.WriteLine();
            Console.WriteLine();

            Vare v2 = new Vare("Sukker", 15);
            Console.WriteLine("Prisen inkl. moms på " + v2.Navn + "er " + v2.PrisMedMoms());






            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
            
        }

        class Vare
        {
            private string navn;

            public string Navn
            {
                get
                {
                    Console.WriteLine("Navnet " + navn + " hentes");
                    return navn;
                }
                set
                {
                    Console.WriteLine("Navnet på varen er sat til " +value);
                    navn = value;
                }
            }

            private double pris;

            public double Pris
            {
                get
                {
                    Console.WriteLine("Prisen " + pris + " hentes");
                    return pris;
                }
                set
                {
                    Console.WriteLine("Prisen på varen er sat til " + value);
                    pris = value;
                }
            }

            public Vare (string Navn, double Pris)
            {
                this.Navn = Navn;
                this.Pris = Pris;
            }
            public Vare ()
            {
                this.Navn = "";
                this.Pris = 0;
            }

            public double PrisMedMoms()
            {
                return this.Pris * 1.25;
            }

        }
    }
}
