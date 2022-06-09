using System;
using System.Collections.Generic;
using System.Text;

namespace TilmildingsSystemet
{
    public class PatruljeFører : Person
    {
        public bool OK { get; set; }

        public PatruljeFører(int id, string navn, string adresse, string patrulje, DateTime fødselsdag, bool enUge) 
            : base(id, navn, adresse, patrulje, fødselsdag, enUge)
        {
            OK = false;
            DateTime today = DateTime.Today;
            int is18 = today.Year - fødselsdag.Year;    
            if (is18 >= 18) OK = true;
           
        }
    }
}
