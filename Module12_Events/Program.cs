using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_Events
{
    class Program
    {
        static void Main(string[] args)
        {

            Kunde k = new Kunde() { KreditMax = -500 };
            k.KreditOverskredet += (s, e) => { Console.WriteLine("Kredit overskredet"); };  //Hvis event kommer skrives "Kredit overskredet" i konsol
            k.Køb(100);
            Console.WriteLine("Købt for 100");
            k.Køb(600);
            Console.WriteLine("Købt for 600");



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }


        public class Kunde
        {

            public event EventHandler KreditOverskredet;    //Event
            public string Navn { get; set; }
            public int Saldo { get; set; }
            public int KreditMax { get; set; }

            public void Køb(int værdi)
            {
                Console.WriteLine("Kunde {0} køber for {1}", Navn, værdi);
                this.Saldo -= værdi;
                if (this.Saldo < this.KreditMax && KreditOverskredet != null)   //Kode vil fejle, hvis Event bliver kaldt, uden at indeholde noget.
                    KreditOverskredet(this, new EventArgs());       //kode definerer hvornår Event skal køres

            }
        }
    }
}

