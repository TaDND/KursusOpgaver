using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Maskine m = new Maskine();  //Opretter by maskine
            m.Log = Console.WriteLine;  //Tilføjer cw til maskines delegate ved navn log
            m.Log += txt=> { System.IO.File.AppendAllText(@"C:\temp\log.txt", txt + "\r\n"); };     //Ligger anonym metode ind i maskines delegate. Sker ved hjælp af Lamda. Den tager variablen "txt" og ligger over i funktionen til højre for pilen, hvor txt bliver skrevet ned i en txt-fil, sammen med et timestamp.
            

            m.Start();
            m.Stop();
            
            
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        //static void AppendLog (string txt)
        //{
        //    System.IO.File.AppendAllText(@"C:\temp\log.txt", txt + "\r\n");
        //}


        public class Maskine
        {
            public Action<string> Log { get; set; }     //Delegate egenskab

            public void Start()
            {
                Log(DateTime.Now.TimeOfDay.ToString() + " Starter");
            }
            public void Stop()
            {
                Log(DateTime.Now.TimeOfDay.ToString() + " Stopper");
            }
        }
    }




}
