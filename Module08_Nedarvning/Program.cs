using System;
using Teknologisk;

namespace Module08_Nedarvning
{
    class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            Console.WriteLine("Ludoterning:");
            LudoTerning l = new LudoTerning();

            Console.WriteLine(l.Værdi);
            Console.WriteLine(l.ErGlobus().ToString());
            Console.WriteLine(l.ErStjerne().ToString());
            l.Ryst();
            Console.WriteLine(l.Værdi);


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Start globus loop");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            while (l.ErGlobus()==false) //Loop bliver ved med at køre indtil, Ludoterning slår en globus.
            {
                i++;    //Tæller antal ryst
                Console.WriteLine("antal ryst: " +i);
                l.Ryst();   //Ryster ludoterning
                Console.WriteLine();    
                Console.WriteLine();
            }
            

            Console.WriteLine();
            Console.WriteLine(l.ErGlobus().ToString());
            Console.WriteLine(l.Værdi);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Almindelig terning:");

            Terning t = new Terning();
            Console.WriteLine(t.Værdi);
            t.Ryst();
            Console.WriteLine(t.Værdi);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Terning
        {
            private static Random rnd;
            private int værdi;


            public int Værdi
            {

                get
                {
                    Console.WriteLine("Der hentes en værdi");
                    return this.værdi;
                                    }
                set
                {
                    if (value < 1 || value > 6)
                        this.værdi = 1;
                    else
                        this.værdi = value;
                    Console.WriteLine("Der sættes en værdi");
                }
            }
            //Statisk constructor
            static Terning()
            {
                rnd = new Random();
            }
            //Default constructor
            public Terning()
            {
                Ryst();
            }
            //Custom constructor
            public Terning(int value)
            {
                Værdi = value;
            }
            //Offentlig metode ryst
            public void Ryst()
            {
                this.Værdi = rnd.Next(1, 7);
            }
            //Offentlig metode skriv
            public void Skriv()
            {
                Console.Write(("[" + this.Værdi + "]").PadRight(5));
            }
        }

        class LudoTerning : Terning
        {

            /// <summary>
            /// Tjekker om terningen er en globus
            /// </summary>
            /// <returns></returns>
            public bool ErGlobus()
            {
                return this.Værdi == 3;
            }
            /// <summary>
            /// Tjekker om terningen er en stjerne
            /// </summary>
            /// <returns></returns>
            public bool ErStjerne()
            {
                return this.Værdi == 5;
            }
            /// <summary>
            /// Default constructor, sendes videre til parent/base
            /// </summary>
            public LudoTerning() : base(){}
            /// <summary>
            /// Custom constructor, sendes videre til parent/base
            /// </summary>
            /// <param name="værdi"></param>
            public LudoTerning(int værdi) : base(værdi) {}
        }
    }
}