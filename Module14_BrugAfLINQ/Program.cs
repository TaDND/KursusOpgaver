using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14_BrugAfLINQ
{
    class Program
    {
        static void Main(string[] args)
        {

            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);


            //foreach (var person in people)
            //{
            //    Console.WriteLine(person.Name);
            //}

            var res1 = people.OrderBy(x => x.Name);
            //foreach (var person in res1)
            //{
            //    Console.WriteLine(person.Name);
            //}

            var res2 = people.OrderBy(x => x.Name).OrderBy(x => x.Gender);
            //foreach (var person in res2)
            //{
            //    Console.WriteLine(person.Name);
            //}

            var res3 = people.Where(x => x.Height < 170);
            //foreach (var person in res3)
            //{
            //    Console.WriteLine(person.Height);
            //}

            var res4 = people.Where(x => x.Gender == PersonNuGetPackage.Gender.Female && x.Height < 170 && x.IsHealthy == true);
            //foreach (var person in res4)
            //{
            //    Console.WriteLine(person.Height + person.Gender.ToString() + person.IsHealthy.ToString());
            //}

            var res5 = people.GroupBy(x => x.Gender);
            //foreach (var item in res5)
            //{
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1.Name);
            //    }
            //    Console.WriteLine();

            //}

            
            

            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }
        }
    }
}
