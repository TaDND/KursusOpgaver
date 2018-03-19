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
                
                get { return værdi; }
                set
                {
                    if (value<1 ||value>6)
                        værdi = 1;
                    else
                        værdi = value;
                }
            }
            static Terning()
            {
                rnd = new Random();
            }

            public Terning()
            {
                Ryst();
            }
            public Terning(int Value)
            {
                Værdi = Value;
            }

            public void Ryst()
            {
                this.Værdi = rnd.Next(1, 6);                
            }

            public void Skriv()
            {
                Console.Write("[" + Værdi + "]"); 
            }
        }
        class YatzyBæger
        {
            private Terning[] terninger;

            public YatzyBæger()
            {
                terninger = new Terning[5];
                for (int i = 0; i < 5; i++)
                {
                    terninger[i] =new Terning();
                }
            }
            public void Ryst()
            {
                foreach (Terning terning in terninger)
                {
                    terning.Ryst();
                }
            }

            public void Skriv()
            {
                foreach (Terning terning in terninger)
                {
                    terning.Skriv();
                }
                Console.WriteLine();
            }

                
        }
    }
}
