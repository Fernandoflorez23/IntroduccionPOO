using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Aldea
    {
        private string nombre;
        private string ubicacion;

        public Habitante[] habitantes = new Habitante[100];


        //constructor
        public Aldea(string nombre, string ubicacion)
        {
            this.nombre = nombre.ToUpper();
            this.ubicacion = ubicacion;
        }

        //logica de negocio
        public void RecibirHabitante(Habitante unHabitante)
        {
            int posicionVacia = 0;
            foreach (Habitante habitante in this.habitantes)
            {
                posicionVacia++;
                if (posicionVacia < 100)
                {
                    habitantes[posicionVacia-1] = unHabitante;
                }
            }

        }

        // encapsulacion gets y sets
        public string getNombre()
        {
            return this.nombre;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre.ToUpper();
        }
        public string getUbicacion()
        {
            return this.ubicacion;
        }
        public void setUbicacion(string ubicacion)
        {
            this.ubicacion = ubicacion;
        }
        public Habitante[] getHabitantes()
        {
            return this.habitantes;
        }
        public void setHabitantes(Habitante [] habitantes)
        {
            this.habitantes = habitantes;
        }

    }
}
