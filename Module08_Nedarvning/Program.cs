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

            Console.WriteLine(l.V�rdi);
            Console.WriteLine(l.ErGlobus().ToString());
            Console.WriteLine(l.ErStjerne().ToString());
            l.Ryst();
            Console.WriteLine(l.V�rdi);


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Start globus loop");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            while (l.ErGlobus()==false) //Loop bliver ved med at k�re indtil, Ludoterning sl�r en globus.
            {
                i++;    //T�ller antal ryst
                Console.WriteLine("antal ryst: " +i);
                l.Ryst();   //Ryster ludoterning
                Console.WriteLine();    
                Console.WriteLine();
            }
            

            Console.WriteLine();
            Console.WriteLine(l.ErGlobus().ToString());
            Console.WriteLine(l.V�rdi);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Almindelig terning:");

            Terning t = new Terning();
            Console.WriteLine(t.V�rdi);
            t.Ryst();
            Console.WriteLine(t.V�rdi);



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
            private int v�rdi;


            public int V�rdi
            {

                get
                {
                    Console.WriteLine("Der hentes en v�rdi");
                    return this.v�rdi;
                                    }
                set
                {
                    if (value < 1 || value > 6)
                        this.v�rdi = 1;
                    else
                        this.v�rdi = value;
                    Console.WriteLine("Der s�ttes en v�rdi");
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
                V�rdi = value;
            }
            //Offentlig metode ryst
            public void Ryst()
            {
                this.V�rdi = rnd.Next(1, 7);
            }
            //Offentlig metode skriv
            public void Skriv()
            {
                Console.Write(("[" + this.V�rdi + "]").PadRight(5));
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
                return this.V�rdi == 3;
            }
            /// <summary>
            /// Tjekker om terningen er en stjerne
            /// </summary>
            /// <returns></returns>
            public bool ErStjerne()
            {
                return this.V�rdi == 5;
            }
            /// <summary>
            /// Default constructor, sendes videre til parent/base
            /// </summary>
            public LudoTerning() : base(){}
            /// <summary>
            /// Custom constructor, sendes videre til parent/base
            /// </summary>
            /// <param name="v�rdi"></param>
            public LudoTerning(int v�rdi) : base(v�rdi) {}
        }
    }
}