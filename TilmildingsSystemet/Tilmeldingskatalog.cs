using System;
using System.Collections.Generic;
using System.Linq;

namespace TilmildingsSystemet
{
    public class Tilmeldingskatalog
    {
        private string _lejrID;
        private bool _ugeRegel;
        private DateTime _startDato;
        private DateTime _slutDato;
        private Dictionary<int, Person> _personer;
        private List<Person> _listPersoner;

        public Tilmeldingskatalog(string lejrID, bool ugeRegel, DateTime start, DateTime slut)
        {
            _lejrID = lejrID;
            _ugeRegel = ugeRegel;
            _startDato = start;
            _slutDato = slut;
            _personer = new Dictionary<int, Person>();
            _listPersoner = new List<Person>();
            int numberOfDays = (_slutDato - _startDato).Days;
           
            if (_startDato >= _slutDato)
            {
                throw new ArgumentException($"{_lejrID} Start tidspunkt er den samme eller senere end slut tidspunkt");
            }
            if ( _ugeRegel == true && numberOfDays != 14)
            {
                throw new ArgumentException($"Tidsrum skal være 14 dage");
            }
        }

        public string LejrID
        { get { return _lejrID; } set { _lejrID = value; } }
        public bool UgeRegel
        { get { return _ugeRegel; } set { _ugeRegel = value; } }
        public DateTime StartDato
        { get { return _startDato; } 
            set 
            { 
                _startDato = value;
                if (_startDato >= _slutDato)
                {
                    throw new ArgumentException($"Start tidspunkt er den samme eller senere end slut tidspunkt");
                }
            } 
        }
        public DateTime SlutDato
        { get { return _slutDato; } set { _slutDato = value; } }
        public Dictionary<int, Person> Personer
        { get { return _personer; } set { _personer = value; } }

        #region Dictionary
        public void AddPerson(Person p)
        {
            _personer.Add(p.ID, p);
        }

        public void DeletePerson(int id)
        {
            _personer.Remove(id);
        }

        public override string ToString()
        {
            string strToReturn = string.Empty;
            while (_personer.Count > 0)
            {
                strToReturn += "Personer: \n";
                //foreach (Person p in _personer.Values)
                //{
                //    strToReturn += p + "\n";
                //}
                //break;
                for (int i = 0; i < _personer.Count; i++)
                {
                    strToReturn += _personer.ElementAt(i) + "\n";
                }
                break;
            }
            return $"LejrID: {_lejrID}, Uge regel: {_ugeRegel}, start dato: {_startDato}, slut dato: {_slutDato}\n{strToReturn}";
        }
        #endregion
        #region List
        public void ListAddPerson(Person p)
        {
            _listPersoner.Add(p);
        }
        public void ListDeletePerson(int id)
        {
            foreach(var p in _listPersoner)
            {
                if(p.ID == id)
                {
                    _listPersoner.Remove(p);
                    break;
                }
            }
        }
        //public override string ToString()
        //{
        //    string strToReturn = string.Empty;
        //    while (_personer.Count > 0)
        //    {
        //        strToReturn += "Personer: \n";
        //        for (int i = 0; i < _listPersoner.Count; i++)
        //        {
        //            strToReturn += _listPersoner[i] + "\n";
        //        }
        //        break;
        //    }
        //    return $"LejrID: {_lejrID}, Uge regel: {_ugeRegel}, start dato: {_startDato}, slut dato: {_slutDato}\n{strToReturn}";
        //}


        #endregion
    }
}