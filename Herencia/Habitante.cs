using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    public class Habitante
    {
        private int id;
        private string nombre;
        private char genero;
        private string oficio;
        private DateTime fechaNacimiento;
        private DateTime fechaDeMuerte;

        public Habitante(int id, string nombre, char genero, string oficio, DateTime fechaNacimiento)
        {
            this.id = id;
            this.nombre = nombre;
            this.genero = genero;
            this.oficio = oficio;
            this.fechaNacimiento = fechaNacimiento;
        }

        public string correr()
        {
            return "Estoy corriendo";
        }

        public string caminar()
        {
            return "Estoy caminando";
        }

        public static int ContadorNombresRepetidos(string nombreSpawner, string nombreConsulta)
        {
            int VecesRepetidas=0;

            if (nombreConsulta.Equals(nombreSpawner))
            {
                VecesRepetidas++;
            }
            return VecesRepetidas;
        }

        public override string ToString()
        {
            return "Id: "+id+" \nNombre: " + nombre + " \nGenero: " + genero+ " \nOficio: " + oficio+ 
                " \nFecha de Nacimiento: " +fechaNacimiento;
        }



        //Gets y sets
        public string Nombre 
        { 
            get => nombre; 
            set => nombre = value; 
        }
        public char Genero 
        { 
            get => genero; 
            set => genero = value; 
        }
      
        public string getFechaNacimiento()
        {
            return this.fechaNacimiento.Year +" / "+ this.fechaNacimiento.Month;
        }

        public void setFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public string Oficio 
        { 
            get => oficio; 
            set => oficio = value; 
        }
    }
}
