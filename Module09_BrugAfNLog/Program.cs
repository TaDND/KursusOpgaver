using System;
using Teknologisk;

namespace Module09_BrugAfNLog
{
    class Program
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        static void Main(string[] args)
        {
            logger.Debug("App start");

            logger.Trace("Start test1");
            int i = Test1(10);
            logger.Trace("Retur fra test1");


            try
            {
                logger.Trace("Start test2");
                Test2();
                logger.Trace("Retur fra test2");
            }
            catch (Exception)
            {

                logger.Error("Fejl");
            }


            logger.Debug("App slut");
            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        public static int Test1(int a)
        {
            logger.Trace("Test1 igang");

            //Kode
            logger.Trace("Test1 færdig");
            return a + 1;
            
        }

        public static void Test2()
        {
            logger.Trace("Test2 igang");
            //Kode
            logger.Trace("Test2 færdig");
            object o = null;
            o.ToString();

        }

    }
}