using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_KlasserOgArrays
{
    class Program
    {
        static void Main(string[] args)
        {

            YatzyBæger b = new YatzyBæger();
            b.Skriv();
            b.Ryst();
            b.Skriv();


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
                
                get { return this.værdi; }
                set
                {
                    if (value<1 ||value>6)
                        this.værdi = 1;
                    else
                        this.værdi = value;
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
            public Terning(int Value)
            {
                Værdi = Value;
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
        class YatzyBæger
        {
            private Terning[] terninger;    //Variabel der kan pege på array af Terning

            //Default constructor
            public YatzyBæger()
            {
                this.terninger = new Terning[5];    //Opretter nyt array af Terning på heap, og lader variablen "terninger" pege på dette nye array.
                for (int i = 0; i < 5; i++)
                {
                    this.terninger[i] =new Terning();   
                }

            }
            /// <summary>
            /// Skifter værdi på alle terninger
            /// </summary>
            public void Ryst()
            {
                foreach (Terning terning in this.terninger) //"Ryster" hver enkelt terning en af gangen
                {
                    terning.Ryst();
                }
            }
            /// <summary>
            /// Udskriver værdi af hver enkelt terninger
            /// </summary>
            public void Skriv()
            {
                foreach (Terning terning in this.terninger) //Skriver værdi af hver enkelt terning ud
                {
                    terning.Skriv();
                }
                Console.WriteLine();
            }

                
        }
    }
}
