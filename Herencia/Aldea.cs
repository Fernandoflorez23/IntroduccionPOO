using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Aldea
    {
        private string nombre;
        private string ubicacion;
        private int totalGuerreros=0, totalAldeanos = 0;

        public Habitante[] habitantes = new Habitante[100];

        //constructor
        public Aldea(string nombre, string ubicacion)
        {
            this.nombre = nombre.ToUpper();
            this.ubicacion = ubicacion;
        }

        //logica de negocio
        public void RecibirHabitante(Habitante unhabitante)
        {
            int posicionVacio = 0;
            foreach (Habitante habitante in this.habitantes)
            {
                if (habitante == null)
                    break;
                posicionVacio++;
            }
            if (posicionVacio < 100)
                habitantes[posicionVacio] = unhabitante;
        }

        /* contar guerreros y aldeanos
         */
        public void contarGuerrerosyAldeanos()
        {
            for(int i=0; i < this.habitantes.Length; i++)
            {
                if (habitantes[i].GetType().Name.Equals("Guerrero"))
                    totalGuerreros++;
                else
                    totalAldeanos++;
            }

            /*foreach (Habitante habitante in this.habitantes)
            {       if (habitantes.GetType().Name.Equals("Guerrero"))
                         totalGuerreros++;
                    else
                        totalAldeanos++;
            }*/
        }

        /**/
        public int contarHabitantesPorNombre(string nombre)
        {
            int habitantesConElMismoNombre=0;
            foreach (Habitante unHabitante in this.habitantes)
            {
                if (nombre.Equals(unHabitante.Nombre))
                    habitantesConElMismoNombre++;
            }
            return habitantesConElMismoNombre;
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

        public int getTotalGuerreros()
        {
            return this.totalGuerreros;
        }

        public int getTotalAldeanos()
        {
            return this.totalAldeanos;
        }


    }
}
