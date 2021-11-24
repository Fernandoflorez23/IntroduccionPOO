using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinal
{
    class Veterinary : Employee
    {
        private string university;
        private string specialty;
        public Veterinary(string university, string specialty,string firstName, string lastName, DateTime birthDate, DateTime startDate, double salary) : base(firstName,lastName,birthDate,startDate,salary)
        {
            this.university = university;
            this.specialty = specialty;
        }
    }
}
