using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11_GeneriskKlasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Bæger b = new Bæger();  

            b.Tilføj(new YatzyTerning());
            b.Tilføj(new LudoTerning());

            LudoTerning e = b.Terninger()[1] as LudoTerning;
            Console.WriteLine(e.ErGlobus());


            Bæger1<LudoTerning> b1 = new Bæger1<LudoTerning>();
            b1.Tilføj(new LudoTerning());
            b1.Tilføj(new LudoTerning());
            //b1.Tilføj(new YatzyTerning());            --Vil fejle, da Bæger1 er generisk


            LudoTerning e1 = b1.Terninger()[1];
            Console.WriteLine(e1.ErGlobus());




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public abstract class Terning
        {
            private static System.Random rnd = new Random();
            public int Værdi { get; private set; }
            public void Ryst()
            {
                Værdi = rnd.Next(1, 7);
            }
            public override string ToString()
            {
                return "[" + this.Værdi + "]";
            }
        }

        public class YatzyTerning : Terning
        {
            public YatzyTerning()
            {
                this.Ryst();
            }
        }

        public class LudoTerning : Terning
        {
            public override string ToString()
            {
                if (this.ErStjerne())
                    return "[S]";
                if (this.ErGlobus())
                    return "[G]";
                return base.ToString();
            }

            public LudoTerning()
            {
                this.Ryst();
            }

            public bool ErStjerne()
            {
                return this.Værdi == 5;
            }
            public bool ErGlobus()
            {
                return this.Værdi == 3;
            }
        }

        public class Bæger
        {
            private List<Terning> lst = new List<Terning>();
            public void Tilføj(Terning d)
            {
                lst.Add(d);
            }
            public List<Terning> Terninger()
            {
                return lst;
            }
        }
        public class Bæger1<T> where T : Terning
        {
            private List<T> lst = new List<T>();
            public void Tilføj(T d)
            {
                lst.Add(d);
            }
            public List<T> Terninger()
            {
                return lst;
            }
        }


    }
}
