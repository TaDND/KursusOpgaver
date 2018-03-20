using System;
using Teknologisk;

namespace Module08_Polymorfi_Dyr
{
    class Program
    {
        static void Main(string[] args)
        {



            //Hund h = new Hund { Navn = "Fido" };
            //Kat k = new Kat { Navn = "Findus" };

            //h.SigNoget();
            //k.SigNoget();

            Dyr[] dyr = new Dyr[20];    //Nyt array af dyr

            for (int i = 0; i < 20; i++)    //20 gange bliver loopet l�bet igennem, og kalder metoden Tilf�ldigtDyr, som returnerer enten en hund eller en kat, med et tilf�ldigt navn fra en fil p� x drev 
            {
                dyr[i] = Dyr.Tilf�ldigtDyr();
            }

            foreach (var item in dyr)   //For hver Dyr i dyr, bliver metoden SigNoget kaldt, som skriver i consollen, om det er en hund eller en kat, og hvad den hedder.
            {
                item.SigNoget();
            }


            
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        
    }
    abstract class Dyr
    {
        static Random rnd = new Random();   //Ny rng
        public string Navn { get; set; }

        public virtual void SigNoget()
        {
            Console.WriteLine($"Jeg er et dyr og hedder {Navn}");
        }

        /// <summary>
        /// Returnerer enten en hund eller en kat, med et tilf�ldigt navn.
        /// </summary>
        /// <returns></returns>
        public static Dyr Tilf�ldigtDyr ()
        {
            int i;
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);  //L�ser alle linjer i txt-fil og smider dem ind i et array af strings.
            

            i = rnd.Next(0, navne.Length);  //Finder nyt tilf�ldigt tal mellem 0 og arrayets l�ngde.

            if (i<navne.Length/2)       //Er det tilf�ldige tal mindre end halvdelen af arrayets l�ngde, returneres en kat.
            {
                return new Kat {Navn = navne[i] };
            }
            else                        //Er det tilf�ldige tal st�rre end halvdelen af arrayets l�ngde, returneres en hund.
            {
                return new Hund { Navn = navne[i] };
            }
            
        }

    }

    class Hund : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en hund og hedder {Navn}");
        }
    }

    class Kat : Dyr
    {
        public override void SigNoget()
        {
            Console.WriteLine($"Jeg er en kat og hedder {Navn}");
        }
    }
}   