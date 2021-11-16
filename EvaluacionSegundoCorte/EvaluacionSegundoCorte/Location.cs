using System;
using System.Collections.Generic;
using System.Text;

namespace EvaluacionSegundoCorte
{
    class Location
    {
        private string street;
        private string city;
        private string country;

        public Location(string street, string city, string country)
        {
            this.street = street;
            this.city = city;
            this.country = country;
        }

        public string getStreet()
        {
            return this.street;
        }

        public void setStreet(string street)
        {
            this.street = street;
        }

        public string getCity()
        {
            return this.city;
        }

        public void setCity(string city)
        {
            this.city = city;
        }

        public string getCountry()
        {
            return this.country;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }
    }
}
