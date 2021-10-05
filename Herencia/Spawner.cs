using System;
using System.Collections.Generic;
using System.Text;

namespace Herencia
{
    class Spawner
    {
        private static int generadorId()
        {
            Random rd = new Random();
            return rd.Next(0,100);
        }

        private static string generadorNombres()
        {
            string[] nombresHabitantes = { "Alaric the Visigoth", "Count Roland", "Horatius Cocles", 
                "Prince Rupert of the Rhine", "Vercingetorix","William Wallace","Basil II","Attila the Hun", 
                "Yue Fei","Eric Bloodaxe","Arminius","Miltiades","Vlad the Impaler","Sun Tzu","Scipio Africanus",
                "Spartacus","Xiahou Dun","Hannibal Barca","Pyrrhus of Epirus","Richard the Lionheart","Miyamoto Musashi",
                "Julius Caesar","Leonidas of Sparta","Genghis Khan","Alexander the Great"};
            Random rd = new Random();
            int posicion = rd.Next(0, 25);
            return nombresHabitantes[posicion];
        }

        private static char generadorGenero()
        {
            Random rd = new Random();
            char[] genero = { 'M', 'F' };
            int posicion = rd.Next(0, 2);
            return genero[posicion];
        }

        private static string generadorOficio()
        {
            Random rd = new Random();
            string[] oficio = {"Guerrero","Aldeano"};
            int posicion = rd.Next(0, 2);
            return oficio[posicion];
        }

        private static DateTime generarFechaNacimiento()
        {
            Random rd = new Random();
            int dia = rd.Next(1, 29);
            int mes = rd.Next(1,13);
            int año = rd.Next(280,305);
            DateTime fechaNacimiento = new DateTime(año,mes,dia);
            return fechaNacimiento;
        }

        public static Habitante generarNuevoHabitante()
        {
            int id = generadorId();
            string nombre = generadorNombres();
            char genero = generadorGenero();
            string oficio = generadorOficio();
            DateTime fechaNacimiento = generarFechaNacimiento();

            Random rd = new Random();
            int tipo = rd.Next(0,2);

            if (tipo == 0)
            {  //Guerrero(string tipoGuerrrero, int id, string nombre, char genero, string oficio, DateTime fechaNacimiento)
                Guerrero unGuerrero = new Guerrero("Arquero", id, nombre, genero, oficio, fechaNacimiento);
                return unGuerrero;
            }
            Aldeano unAldeano = new Aldeano (id, nombre, genero, oficio, fechaNacimiento);
            return unAldeano;
        }
    }
}
