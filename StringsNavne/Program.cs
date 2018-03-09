using System;

namespace StringsNavne
{
    class Program
    {
        static void Main(string[] args)
        {


            string fornavn = "Mikkel";
            string efternavn = "Cronberg";
            string samletNavn = fornavn + " " + efternavn;
            string navnStort = samletNavn.ToUpper();
            string navnLille = samletNavn.ToLower();

            string del = samletNavn.Substring(samletNavn.IndexOf("Cronberg"),4);
            //Console.WriteLine(del);

            string[] sa = new string[2];
            sa = samletNavn.Split(' ');

            for (int i = 0; i < sa.Length; i++)
            {
                Console.WriteLine(sa[i]);
            }
            Console.WriteLine(@"\t \t \t \t:");
            Console.WriteLine(sa[0] + "\t \t \t \t" + sa[1]);
            Console.WriteLine(@"\n:");
            Console.WriteLine(sa[0] + "\n" + sa[1]);
            Console.WriteLine(@"\r:");
            Console.WriteLine(sa[0] + "\r" + sa[1]);
            Console.WriteLine(@"\r\n:");
            Console.WriteLine(sa[0] + "\r\n" + sa[1]);

            System.IO.File.WriteAllText(@"c:\temp\test.txt", fornavn+ efternavn+ samletNavn+ navnStort+ navnLille);



            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
