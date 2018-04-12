using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_BrugAfEgetInterface
{
    class Program
    {
        static void Main(string[] args)
        {

            IDbFunktioner[] IDber = new IDbFunktioner[4];   //Opretter nyt array af IDbFunktioner
            Hund h1 = new Hund();   //Opretter variabel der kan pege på hund og laver instans på heap
            IDber[0] = h1;          //Lægger h1 ind i array
            Ubåd u1 = new Ubåd();   //Opretter variabel der kan pege på ubåd og laver instans på heap
            IDber[1] = u1;          //Lægger u1 ind i array
            Hund h2 = new Hund();   //Opretter variabel der kan pege på hund og laver instans på heap
            IDber[2] = h2;          //Lægger h2 ind i array
            Ubåd u2 = new Ubåd();   //Opretter variabel der kan pege på ubåd og laver instans på heap
            IDber[3] = u2;          //Lægger u2 ind i array

            foreach (var item in IDber) //Løber array igennem
            {
                item.Gem();             //Kalder metoden "Gem" for hver ting i array
            }

            /* Resultat:
             * Gemmer Hund
             * Gemmer Ubåd
             * Gemmer Hund
             * Gemmer Ubåd*/

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        interface IDbFunktioner
        {
            void Gem();
        }

        public class Hund : IDbFunktioner
        {
            public void Gem()
            {
                Console.WriteLine("Gemmer Hund");
            }
        }

        public class Ubåd : IDbFunktioner
        {
            public void Gem()
            {
                Console.WriteLine("Gemmer Ubåd");
            }
        }

    }
}
