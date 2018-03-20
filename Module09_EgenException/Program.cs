using System;
using Teknologisk;

namespace Module09_EgenException
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                StockItem s = new StockItem(-1);
            }
            catch (StockItemException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Stockitem Exception");
            }
            catch (Exception)
            {
                Console.WriteLine("General Error");
            }




            // Keep console window open when using the debugger (F5)
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }

    class StockItem
    {
        public int ID { get; set; }

        public StockItem(int id)
        {
            if (id >= 0)
                this.ID = id;
            else
                throw new StockItemException("Wrong ID");
        }

    }
    class StockItemException : Exception
    {
        public StockItemException(string message) : base (message)
        {
            
        }
    }
}