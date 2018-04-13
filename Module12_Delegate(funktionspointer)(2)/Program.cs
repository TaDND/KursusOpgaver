using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module12_Delegate_funktionspointer__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            int res=Beregner(3, 2, Plus);
            Console.WriteLine(res);
            res = Beregner(3, 2, Minus);
            Console.WriteLine(res);
            res = Beregner(3, 2, Gange);
            Console.WriteLine(res);
            res = Beregner(3, 2, Divider);
            Console.WriteLine(res);


            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        public static int Beregner(int a, int b, Func<int, int, int> f)     //Metode der tager 2 int's og en Func der tager 2 int's og returnerer en int
        {
            return f(a, b);      //Kører delegate med de angivne int's. Er kan være en vilkensomhelst funktion, der blot skal returnere en int, og tager 2 int's som argumenter
            //Dette kan kun lade sig gøre, fordi det er en reference til en funktion.
        }

        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }

        public static int Divider(int a, int b)
        {
            return a / b;
        }

        public static int Gange(int a, int b)
        {
            return a * b;
        }
    }
}
