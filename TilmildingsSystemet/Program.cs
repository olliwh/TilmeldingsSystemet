using System;

namespace TilmildingsSystemet
{
    class Program
    {
        static void Main(string[] args)
        { 
            Person p1 = new Person(1, "Bo", "vej 22", "hvad er en patrulje???", new DateTime(2010, 10, 1), true);
            Person p2 = new Person(2, "ib", "vej 22", "hvad er en patrulje???", new DateTime(2010, 10, 1), false);
            Person p3 = new Person(3, "ea", "vej 22", "hvad er en patrulje???", new DateTime(2010, 10, 1), true);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            

            Tilmeldingskatalog tk1 = new Tilmeldingskatalog("a1", true, new DateTime(2022, 10, 10), new DateTime(2022, 10, 24));
            tk1.AddPerson(p1);
            tk1.AddPerson(p2);
            tk1.AddPerson(p3);
            Console.WriteLine(tk1);
            tk1.DeletePerson(2);
            tk1.DeletePerson(3);
            Console.WriteLine(tk1);

            Console.WriteLine((tk1.SlutDato - tk1.StartDato).Days);
            Console.WriteLine((tk1.SlutDato - tk1.StartDato).TotalDays);
            Console.WriteLine((tk1.SlutDato - tk1.StartDato).TotalHours);

            Console.WriteLine((tk1.SlutDato.Subtract(tk1.StartDato)).Days);

            Tilmeldingskatalog tk2 = new Tilmeldingskatalog("a1", false, new DateTime(2022, 10, 10), new DateTime(2022, 10, 11));
            tk2.AddPerson(p1);
            tk2.AddPerson(p2);
            tk2.AddPerson(p3);
            Console.WriteLine(tk2);
            tk2.DeletePerson(2);
            tk2.DeletePerson(3);
            tk2.DeletePerson(1);
            Console.WriteLine(tk2);

            PatruljeFører pf1 = new PatruljeFører(1, "tim", "veh2722", "????", new DateTime(2010, 12, 12), false);
            Console.WriteLine(pf1.OK);

            PatruljeFører pf2 = new PatruljeFører(2, "tom", "veh2722", "????", new DateTime(2000, 12, 12), false);
            Console.WriteLine(pf2.OK);

            Console.WriteLine("------------------------------List--------------------------------");
            tk1.ListAddPerson(p1);
            tk1.ListAddPerson(p2);
            tk1.ListAddPerson(p3);
            Console.WriteLine(tk1);
            tk1.ListDeletePerson(2);
            tk1.ListDeletePerson(3);
            Console.WriteLine(tk1);


            Console.WriteLine("Switch between projects: højreklik project vælg 'set as startup'");
        }
    }
}
