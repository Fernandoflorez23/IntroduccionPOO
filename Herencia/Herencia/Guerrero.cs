using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Guerrero : Habitante
    {
        private string tipoGuerrrero;
        
        public Guerrero(string tipoGuerrrero, int id, string nombre, char genero, string oficio, DateTime fechaNacimiento) : base(id, nombre, genero, oficio, fechaNacimiento)
        {
            this.tipoGuerrrero = tipoGuerrrero;
        }

        public string atacar()
        {
            return "Estoy atacando";
        }

        public string defender()
        {
            return "Estoy defendiendo";
        }
    }
}
