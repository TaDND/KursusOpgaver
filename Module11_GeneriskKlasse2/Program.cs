using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11_GeneriskKlasse2
{
    class Program
    {
        static void Main(string[] args)
        {

            //Udkommenterede linjer kode vil skabe errors

            Personer1 p1 = new Personer1();
            p1.Tilføj(new Person { Navn = "Søren" });
            p1.Tilføj(new Instruktør { Navn = "Theis" });
            p1.Tilføj(new Kursist { Navn = "Iben" });
            //p1.Tilføj(1);
            
            Personer2<Person> p2 = new Personer2<Person>();
            p2.Tilføj(new Person { Navn = "Søren" });
            p2.Tilføj(new Instruktør { Navn = "Theis" });
            p2.Tilføj(new Kursist { Navn = "Iben" });

            Personer2<int> p21 = new Personer2<int>();
            p21.Tilføj(1);
            p21.Tilføj(2);
            p21.Tilføj(3);

            Personer3<Kursist> p3 = new Personer3<Kursist>();
            //p3.Tilføj(new Person { Navn = "Søren" });
            //p3.Tilføj(new Instruktør { Navn = "Theis" });
            p3.Tilføj(new Kursist { Navn = "Iben" });

            //Personer3<int> p31 = new Personer3<int>();

            Personer3<Person> p32 = new Personer3<Person>();
            p32.Tilføj(new Person { Navn = "Søren" });
            p32.Tilføj(new Instruktør { Navn = "Theis" });
            p32.Tilføj(new Kursist { Navn = "Iben" });



            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        class Person
        {
            public string Navn { get; set; }
        }

        class Instruktør : Person
        {
            public int NøgleId { get; set; }
        }

        class Kursist: Person
        {
            public int KursistId { get; set; }
        }

        /// <summary>
        /// Liste af personer. Kan derfor både indeholde Personer, instruktører og kursister. Også på en gang.
        /// </summary>
        class Personer1
        {
            private List<Person> lst = new List<Person>();

            public void Tilføj (Person p)
            {
                lst.Add(p);
            }
        }


        /// <summary>
        /// Liste af ens datatyper. Kan derfor ikke både indeholde kursister og instruktører, medmindre det laves som en liste af Personer. Kan dog også være en liste af int, string mm.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class Personer2<T>
        {
            private List<T> lst = new List<T>();

            public void Tilføj(T p)
            {
                lst.Add(p);
            }
        }

        /// <summary>
        /// Liste af ens datatyper, der nedarver fra Person. Kan derfor være en liste af Person (som så kan indeholde både kursist og instruktør).
        /// Kan også være enten kursist eller instruktør. Dog kun en.
        /// Kan ikke være liste af fx int eller string
        /// </summary>
        /// <typeparam name="T"></typeparam>
        class Personer3<T> where T:Person
        {
            private List<T> lst = new List<T>();

            public void Tilføj(T p)
            {
                lst.Add(p);
            }
        }
    }
}
