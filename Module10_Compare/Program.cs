using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_Compare
{
    class Program
    {
        static void Main(string[] args)
        {
            Hund[] hunde = new Hund[3];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 10, Navn = "Fido" };
            hunde[2] = new Hund() { Alder = 5, Navn = "Lady" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Navn);
            }


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Hund : IComparable    //Da Hund nedarver fra IComparable vil denne kunne sorteres udfra den kode, der skrives under metoden CompareTo
        {
            public string Navn { get; set; }
            public int Alder { get; set; }

            public int CompareTo(object obj)    //Metoden definerer hvordan klassen skal sorteres eller sammenlignes med andre instanser af samme klasse.
            {
                Hund forrigeHund = obj as Hund;
                if (this.Alder > forrigeHund.Alder) //Denne instans har en højere alder end den forrige
                    return 1;   //Sætter denne instans efter den forrige
                if (this.Alder < forrigeHund.Alder) //Denne instans har en lavere alder end den forrige 
                    return -1;  //Sætter denne instans før den forrige
                return 0;   //Er akdereb ens vil samme rækkefølge som før beholdes
            }
        }

    }
}
