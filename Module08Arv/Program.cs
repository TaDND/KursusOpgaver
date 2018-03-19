using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08Arv
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();

            p1.Fornavn = "Dennis";
            p1.Efternavn = "Demant";
            Console.WriteLine(p1.FuldtNavn());

            Elev e1 = new Elev { Fornavn = "Elev1", Efternavn = "Elevefternavn1", Klasselokale = "8.2.1" };
            Console.WriteLine(e1.FuldtNavn());

            Instruktør i1 = new Instruktør { Fornavn = "Instruktør1", Efternavn = "Instruktørefternavn1", NøgleId = 254};
            Console.WriteLine(i1.FuldtNavn());


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
        class Person
        {
            public string  Fornavn { get; set; }
            public string Efternavn { get; set; }

            public string FuldtNavn()
            {
                return $"{Fornavn} {Efternavn}";
            }
        }
        class Elev : Person
        {
            public string  Klasselokale { get; set; }
        }
        class Instruktør : Person
        {
            public int NøgleId  { get; set; }

        }
    }
}
