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

            for (int i = 0; i < 20; i++)    //20 gange bliver loopet løbet igennem, og kalder metoden TilfældigtDyr, som returnerer enten en hund eller en kat, med et tilfældigt navn fra en fil på x drev 
            {
                dyr[i] = Dyr.TilfældigtDyr();
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
        /// Returnerer enten en hund eller en kat, med et tilfældigt navn.
        /// </summary>
        /// <returns></returns>
        public static Dyr TilfældigtDyr ()
        {
            int i;
            string sti = @"x:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);  //Læser alle linjer i txt-fil og smider dem ind i et array af strings.
            

            i = rnd.Next(0, navne.Length);  //Finder nyt tilfældigt tal mellem 0 og arrayets længde.

            if (i<navne.Length/2)       //Er det tilfældige tal mindre end halvdelen af arrayets længde, returneres en kat.
            {
                return new Kat {Navn = navne[i] };
            }
            else                        //Er det tilfældige tal større end halvdelen af arrayets længde, returneres en hund.
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