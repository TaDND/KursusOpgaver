using System;

namespace Opg1Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int heltal = 10;
            heltal++;
            heltal--;
            heltal += 20;
            Console.WriteLine(heltal);

            double kommatal = 12.5;
            kommatal++;
            kommatal--;
            kommatal *= 2;
            Console.WriteLine(kommatal);

            var ft = FilTyper.csv;
            Console.WriteLine((int)ft);     //(int) sørger for, at værdien bliver skrevet i stedet for strengen


            DateTime dt = DateTime.Now;
            Console.WriteLine(dt.ToString("ddMMyy"));       //eks. "080318"
            Console.WriteLine(dt.ToString("d-M-y"));          //eks. "8318"
            Console.WriteLine(dt.ToLongDateString());       //eks. "8. marts 2018"

            Person p = new Person();
            p.ID = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        enum FilTyper
        {
            csv,
            pdf,
            txt
        }
        struct Person
        {
            public int ID;
            public string Navn;
        }
    }
}
