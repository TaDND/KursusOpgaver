using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10_BrugAfUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt");
            //while (stream.Peek()!=-1)
            //{
            //    string navn = stream.ReadLine();
            //    Console.WriteLine(navn);
            //}
            //stream.Close();
            //stream = null;

            using (StreamReader stream = System.IO.File.OpenText(@"x:\dyrenavne.txt"))
            {//Ved brug af using på denne måde, vil runtime selv finde ud af, at køre Dispose på det object, der er skrevet i usings parentes
                //Man behøver derfor ikke at huske på at lukke på den rigtige måde.
                //Det kræver dog, at klassen nedarver fra IDisposable

                while (stream.Peek() !=-1)
                {
                    string navn = stream.ReadLine();
                    Console.WriteLine(navn); 
                }
            }
            


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
