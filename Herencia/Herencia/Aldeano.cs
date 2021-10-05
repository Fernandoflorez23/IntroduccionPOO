using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Aldeano: Habitante
    {

        public Aldeano(int id, string nombre, char genero, string oficio, DateTime fechaNacimiento) : base(id,nombre,genero,oficio,fechaNacimiento)
        {

        }
        public string cultivar()
        {
            return "Estoy cultivando";
        }
        public string construir()
        {
            return "Estoy construyendo";
        }


    }
}
