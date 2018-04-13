using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_FileWatch
{
    class Program
    {
        static void Main(string[] args)
        {


            System.IO.FileSystemWatcher w = new System.IO.FileSystemWatcher(@"c:\temp", "*.txt");       //Opretter ny FileWatcher, der kigger på filer i temp-mappe
            w.EnableRaisingEvents = true;       //Enabler events
            w.Changed += (s, e) => { Console.WriteLine("Filen " + e.Name + " er rettet"); };    //Når er fil ændres bruges lambda til at skrive i konsol.
            w.Created += W_Created;

            do
            {
            } while (true);

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void W_Created(object sender, System.IO.FileSystemEventArgs e)
        {
            Console.WriteLine("Filen " + e.Name + " er oprettet");
        }
    }
}
