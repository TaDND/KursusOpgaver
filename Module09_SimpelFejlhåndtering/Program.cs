using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module09_SimpelFejlhåndtering
{
    class Program
    {
        static void Main(string[] args)
        {

            Run();

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }

        private static void Run()
        {
            try
            {
                Console.WriteLine("Indtast 1. tal");
                int tal1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Indtast 2. tal");
                int tal2 = Convert.ToInt32(Console.ReadLine());
                int res = tal1 + tal2;
                Console.WriteLine("Resultatet er " + res);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Der er sket en fejl - " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Program lukkes");
            }

        }
    }


}
