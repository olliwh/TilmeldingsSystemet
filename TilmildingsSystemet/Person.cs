using System;
using System.Collections.Generic;
using System.Text;

namespace TilmildingsSystemet
{
    public class Person
    {
        protected int _id;
        protected string _navn;
        protected string _adesse;
        protected string _patrulje;
        protected DateTime _fødselsdag;
        protected bool _enUge;

        public Person(int id, string navn, string adresse, string patrulje, DateTime fødslelsdag, bool enUge)
        {
            _id = id;
            _navn = navn;
            _adesse = adresse;
            _patrulje = patrulje;
            _fødselsdag = fødslelsdag;
            _enUge = enUge;
        }
        public int ID { get { return _id; } set { _id = value; } }
        public string Navn { get { return _navn; } set { _navn = value; } }
        public string Adresse { get { return _adesse; } set { _adesse = value; } }
        public string Patrulje { get { return _patrulje; } set { _patrulje = value; } }
        public DateTime Fødselsdag { get { return _fødselsdag; } set { _fødselsdag = value; } }
        public bool EnUge { get { return _enUge; } set { _enUge = value; } }

        public override string ToString()
        {
            return $"ID: {_id} Navn: {_navn} Adresse: {_adesse} Patrulje: {_patrulje} FødselsDato: {_fødselsdag} Tilmeldt 1 uge: {_enUge}";
        }
    }
}
