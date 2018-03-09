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
                    if ((i * j)%10==0)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else if (i * j > 50)
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    else if ((i * j) % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    //Console.Write(i*j + "\t");
                    Console.Write((i * j).ToString().PadLeft(5));
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            for (int k = 1; k <= 10; k++)
            {
                for (int l = 1; l <= 10; l++)
                {

                    if ((l * k) % 10 == 0)
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else if (l * k > 50)
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                    else if ((l * k) % 2 == 0)
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    else
                        Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(k*l + "\t");
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
