using System;

namespace Module10_DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {

            {

                /*Resultatet vil her være 4 linier i consollen, hvor nr 1 og 3 altid vil være 1, og nr 2 og 4 vil være et tilfældigt tal fra 1 til 6.
                Der er brugt 2 forskellige "tilfældighedsgeneratorer", hvoraf den ene bruger System.Random, og den anden returnerer en værdi, programmøren selv har angivet.
                Der kunne lige så godt være brugt en helt tredje tilfældighedsgenerator, så længe den nedarver fra interfacet ITilfældighedsGenerator*/


                ITilfældighedsGenerator m = new TilfældighedsGeneratorMock(1);
                Console.WriteLine(m.FindTalTilTerning());
                ITilfældighedsGenerator f = new TilfældighedsGeneratorFramework();
                Console.WriteLine(f.FindTalTilTerning());
            }

            {
                TilfældighedsGeneratorMock m = new TilfældighedsGeneratorMock(1);
                Terning t1 = new Terning(m);
                Console.WriteLine(t1.Værdi);

                TilfældighedsGeneratorFramework f = new TilfældighedsGeneratorFramework();
                Terning t2 = new Terning(f);
                Console.WriteLine(t2.Værdi);
            }

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }

        }
    }

    

    /*Terning skal bruge en ITilfældighedsGenerator.Der skal derfor laves en klasse, der nedarver fra interfacetI TilfældighedsGenerator, og dermed indeholder metoden FindTalTilTerning.
   Det er fuldstændig ligemeget, hvordan tallet bliver fundet. Kan være System.Random, et fastdefineret tal, baseret på baggrundsstøj fra universet, eller et billede af 50 lavalamper.
   Dette giver mulighed for, at udvikleren selv kan definere, hvilken tilfældighedsgenerator han/hun ønsker at bruge til den pågældende applikation*/


    public interface ITilfældighedsGenerator    //Interface til tilfældighedsgenerator. Skal indeholde metoden FindTalTilTerning. Det er i virkeligheden ligegyldigt, hvordan tallet bliver fundet, så længe et tal kan returneres.
    {
        int FindTalTilTerning();
    }

    public class TilfældighedsGeneratorFramework : ITilfældighedsGenerator  //Nedarver fra ITilfældighedsGenerator og bruger System.Random i metoden FindTalTilTerning
    {
        private static System.Random rnd = new System.Random();

        public int FindTalTilTerning()
        {
            return rnd.Next(1, 7);
        }
    }

    public class TilfældighedsGeneratorMock : ITilfældighedsGenerator   //Nedarver fra ITilfældighedsGenerator, men bruges til test, da metoden FindTalTilTerning giver en værdi, der er hardkodet
    {
        private int tal;
        public TilfældighedsGeneratorMock(int tal)
        {
            this.tal = tal;
        }
        public int FindTalTilTerning()
        {
            return this.tal;
        }
    }

    class Terning       //I constructor bliver der angivet hvilken tilfældighedsgenerator terningen skal bruge, når den skal rystes. Altså er det ligemeget, hvordan det eventuelt tilfældige tal bliver genereret, så længe, et tal kan modtages.
    {
        private ITilfældighedsGenerator generator; 

        public int Værdi { get; set; }

        public Terning(ITilfældighedsGenerator rnd)
        {
            generator = rnd;
            Ryst();
        }

        public void Ryst()  //I denne motode, bliver FindTalTilTerning fra ITilfældighedsGenerator brugt, hvilket vil sige, at der bliver modtaget et tal fra en eller uangivet tilfældighedsgenerator, som blot nedarver fra interfacet ITilfældighedsGenerator.
        {
            this.Værdi = generator.FindTalTilTerning();
        }
    }
}

