using System;

namespace LoopTabel
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int i = 1; i <=10 ; i++)
            {
                for (int j = 1; j <= 10; j++)
                {

                    if (i * j > 50)
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(i*j + "\t");

                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
