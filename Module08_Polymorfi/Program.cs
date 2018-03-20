using System;
using Teknologisk;

namespace Module08_Polymorfi
{
    class Program
    {
        static void Main(string[] args)
        {


            Person p = new Person { Fornavn = "Person", Efternavn = "PersonEfternavn" };
            Elev e = new Elev { Fornavn = "Elev", Efternavn = "ElevEfternavn", Klasselokale="8.2.1" };
            Instrukt�r i = new Instrukt�r { Fornavn = "Instrukt�r", Efternavn = "Instrukt�rEfternavn", N�gleId = 802 };

            Person[] lst = new Person[3];
            lst[0] = p;
            lst[1] = e;
            lst[2] = i;

            foreach (var item in lst)
            {
                item.Skriv();
            }



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Person
    {
        public string Fornavn { get; set; }
        public string Efternavn { get; set; }

        public virtual void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn}");
        }

    }

    class Elev : Person
    {
        public string Klasselokale { get; set; }

        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {Klasselokale}");
        }
    }

    class Instrukt�r : Person
    {
        public int N�gleId { get; set; }

        public override void Skriv()
        {
            Console.WriteLine($"{Fornavn} {Efternavn} {N�gleId}");
        }
    }
}