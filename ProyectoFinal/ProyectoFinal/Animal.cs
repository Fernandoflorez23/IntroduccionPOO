using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class Animal
    {
        string name;
        string feeding;
        string habitat;
        string species;
        DateTime birthDate;
        public Animal(string name,string feeding,string habitat,string species, DateTime birthDate)
        {
            this.name = name;
            this.feeding = feeding;
            this.birthDate = birthDate;
        }
        public int getEdad()
        {
            int currentYear = DateTime.Now.Year;
            int year = getBirthDate().Year;
            return currentYear - year;
        }
        public string eat()
        {
            return "Eating...";
        }
        public DateTime getBirthDate()
        {
            return this.birthDate;
        }
        public void setBirthDate(DateTime birthDate)
        {
            this.birthDate = birthDate;
        }
    }
    interface IMammal
    {
        Boolean hair();
        Boolean tail();
    }
    interface IAmphibians
    {
        string swim();
    }
    interface ITerrestrialAnimals
    {
        Boolean walk();
        Boolean jump();
    }
    interface IAquaticAnimals
    {
        Boolean skeleton();
        string swim();
    }
    class Bat : Animal, IMammal
    {
        public Bat(string name, string feeding, string habitat, string species, DateTime birthDate) : base(name, feeding, habitat, species, birthDate)
        {
        }
        public Boolean hair()
        {
            return true;
        }
        public Boolean tail()
        {
            return true;
        }
    }
    class Horse : Animal,IMammal,ITerrestrialAnimals
    {
        public Horse(string name,string feeding,string habitat,string species, DateTime birthDate) : base(name,feeding,habitat,species,birthDate)
        {
        }
        public Boolean hair()
        {
            return true;
        }
        public Boolean tail()
        {
            return true;
        }
        public Boolean walk()
        {
            return true;
        }
        public Boolean jump()
        {
            return true;
        }
    }
    class Frog : Animal, IAmphibians,IAquaticAnimals,ITerrestrialAnimals
    {
        public Frog(string name, string feeding, string habitat, string species, DateTime birthDate) : base(name, feeding, habitat, species, birthDate)
        {
        }
        public Boolean skeleton()
        {
            return true;
        }
        public string swim()
        {
            return "Swimming";
        }
        public Boolean walk()
        {
            return false;
        }
        public Boolean jump()
        {
            return true;
        }

    }
}
