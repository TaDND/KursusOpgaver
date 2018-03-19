using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_EgenskaberTrekant
{
    class Program
    {
        static void Main(string[] args)
        {

            Trekant t1 = new Trekant(10, 10);
            Console.WriteLine(t1.Areal);

            Trekant t2 = new Trekant(5, 2);
            Console.WriteLine(t2.Areal);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class Trekant
    {
        private int grundlinje;

        public int Grundlinje
        {
            get { return grundlinje; }
            private set { grundlinje = value; }
        }

        private int højde;

        public int Højde
        {
            get { return højde; }
            private set { højde = value; }
        }
        public Trekant (int Grundlinje, int Højde)
        {
            this.Grundlinje = Grundlinje;
            this.Højde = Højde;
        }
        


        //Egenskab
        public double Areal
        {
            get
            {
                return this.Grundlinje*this.Højde*0.5;
            }
        }

        //Metode
        //public double Areal()
        //{
        //    return this.Grundlinje * this.Højde * 0.5;
        //}




    }
}
