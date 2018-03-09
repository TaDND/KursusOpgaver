using System;


namespace Terning_1__OffentligeOgPrivateMedlemmer
{
    class Terning
    {
        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();

        public Terning()
        {
            this.værdi = 1;
            this.snyd = false;
        }
        public Terning(bool value)
        {
            this.værdi = 1;
            this.snyd = value;
        }

        public void Skriv()
        {
            Console.WriteLine("["+værdi+"]");
        }

        public void Ryst()
        {
            if (snyd == false)
                this.værdi = rnd.Next(1, 7);
            else
                this.værdi = 6;
        }
    }
}
