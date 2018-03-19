using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07__EgenskaberPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Fornavn = "Dennis";
            p1.Efternavn = "Demant";

            Person p2 = new Person();

            p2.Fornavn = "Dennis2";
            p2.Efternavn = "AB";

            Console.WriteLine(p1.FuldtNavn);
            Console.WriteLine(p2.FuldtNavn);



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
        public string Fornavn{ get; set; }
        private string efternavn;

        public string Efternavn
        {
            get
            {
                return efternavn;
            }
            set
            { if (value.Length>2)
                {
                    efternavn = value;
                }
            else
                {
                    efternavn = "";
                }
            }
        }

        public string FuldtNavn
        {
            get
            {
                return $"{this.Fornavn} {this.Efternavn}";
            }
            
        }



    }
}
