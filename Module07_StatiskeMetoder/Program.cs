using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module07_StatiskeMetoder
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(ArealBeregninger.BeregnArealFirkant(5, 2.2));
            Console.WriteLine(ArealBeregninger.BeregnArealCirkel(5));



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }


    //Statiske metoder/klasser skal ikke have en instans oprettet på heapen. De kan blot bruges med det samme. Tilgengæld kan de ikke have noget at gøre med interne værdier.
    static class ArealBeregninger
    {
        
        public static double BeregnArealFirkant(double højde, double bredde)
        {
            return højde * bredde;
        }
        public static double BeregnArealCirkel(double radius)
        {
            return System.Math.Pow(radius, 2) * System.Math.PI;
        }
    }
}
