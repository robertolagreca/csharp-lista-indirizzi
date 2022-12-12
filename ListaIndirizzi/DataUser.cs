using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaIndirizzi
{
    internal class DataUser
    {
        private string _name, _surname, _address, _city, _province, _zip;

        public DataUser(string name, string surname, string address, string city, string province, string zip)
        {
            _name = name;
            _surname = surname;
            _address = address;
            _city = city;
            _province = province;
            _zip = zip;
        }

        public string GetName() { return _name; }
        public string GetSurname() { return _surname; }
        public string GetAddress() { return _address; }
        public string GetCity() { return _city; }
        public string GetProvince() { return _province; }
        public string GetZip() { return _zip; }

        public void SetName(string name) { _name = name; }
        public void SetSurname(string surname) { _surname = surname; }
        public void SetAddress(string address) { _address = address; }
        public void SetCity(string city) { _city = city; }
        public void SetProvince(string province) { _province = province; }
        public void SetZip(string zip) { _zip = zip; }
    }
}
