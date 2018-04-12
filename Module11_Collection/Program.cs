using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module11_Collection
{
    class Program
    {
        static void Main(string[] args)
        {



            List<Person> Personer = new List<Person>(); //Generisk liste af personer

            Personer.Add(new Person { Id = 1, Navn = "Brian" });
            Personer.Add(new Person { Id = 2, Navn = "Søren" });
            Personer.Add(new Person { Id = 3, Navn = "Flemming" });

            foreach (var item in Personer)
            {
                Console.WriteLine(item.Navn);
            }

            Console.WriteLine();

            Dictionary<int, Person> dic = new Dictionary<int, Person>();    //Generisk dictionary af personer med int som nøgle 

            dic.Add(10, new Person { Id = 1, Navn = "Hans" });
            dic.Add(20, new Person { Id = 1, Navn = "Brit" });
            dic.Add(30, new Person { Id = 1, Navn = "Tina" });

            Console.WriteLine(dic[20].Navn);




            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }


        class Person
        {
            public int Id { get; set; }
            public string Navn { get; set; }
        }
    }


}
