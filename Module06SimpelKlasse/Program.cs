using System;

namespace Module06SimpelKlasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();
            Person p2 = new Person("Dennis", "Demant");
            Person p3 = new Person(1880);

            Console.WriteLine(p1.FuldtNavn());
            Console.WriteLine(p1.Alder());
            Console.WriteLine();
            Console.WriteLine(p2.FuldtNavn());
            Console.WriteLine(p2.Alder());
            Console.WriteLine();
            Console.WriteLine(p3.FuldtNavn());
            Console.WriteLine(p3.Alder());
            Console.WriteLine();



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        class Person
        {
            public string fornavn;
            public string efternavn;
            public int fødselsår;

            public string FuldtNavn()
            {
                return this.fornavn + " " + this.efternavn;
            }
            public int Alder()
            {
                return DateTime.Now.Year - this.fødselsår;
            }
            //Default construtcor
            public Person()
            {
                this.fornavn = "";
                this.efternavn = "";
            }
            //Custom construtcor - med det hele
            public Person(string fornavn, string efternavn, int fødselsår)
            {
                this.fornavn = fornavn.ToUpper();
                this.efternavn = efternavn.ToUpper();
                this.fødselsår= fødselsår;
            }
            //Default construtcors - uden alt. Sender det modtagede videre til den fulde constructor
            public Person(string fornavn, string efternavn) : this(fornavn, efternavn, 1993)
            {
            }
            public Person(int fødselsår) : this("", "", fødselsår)
            {
            }

        }
    }
}
